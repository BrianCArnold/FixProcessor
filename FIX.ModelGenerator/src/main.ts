import { URL } from 'url';
import * as fs from 'fs';
import * as puppeteer from 'puppeteer';
import { typeMap } from './FixToDotNetTypeMap';

const wait = (milliseconds): Promise<null> => {
    return new Promise(resolve => setTimeout(resolve, milliseconds));
}
    
type Listing = {
    code: string;
    name: string;
    url: string;
};
type TagDetail = {
    code: string;
    type: string;
    name: string;
}

type MessageStructure = {
    code: string;
    name: string;
    requiredTags: number[];
    optionalTags: number[];
};

const getTags = async (browser: puppeteer.Browser): Promise<Listing[]> => {
    const page = await browser.newPage();
    await page.goto('https://www.onixs.biz/fix-dictionary/4.4/fields_by_tag.html');
    await page.waitForSelector('table.fixTableBorder table tbody tr');
    
    const tags = await page.evaluate(() => {
        const rows = Array.from(document.querySelectorAll('table.fixTableBorder table tbody tr'));
        return rows
            .slice(1)
            .map(m => {
                //Reminder, nth-child is 1-indexed.
                const tagCode = m.querySelector('td:nth-child(1) a');
                const tagName = m.querySelector('td:nth-child(2) a');
                return {code: tagCode?.innerHTML, name: tagName?.innerHTML, url: tagCode?.getAttributeNode('href')?.value};
            });
    });
    await page.close();
    return tags;
}


const getTagType = async (browser: puppeteer.Browser, listing: Listing): Promise<TagDetail> => {
    const page = await browser.newPage();
    console.log('Getting Tag Type for ' + listing.code);
    console.log('Going to URL: ' + `https://www.onixs.biz/fix-dictionary/4.4/${listing.url}`);
    await page.goto(`https://www.onixs.biz/fix-dictionary/4.4/${listing.url}`);
    const tagType = await page.evaluate(() => {
        const usedInLink = document.querySelector('a[href="#UsedIn"]');
        const parentElement = usedInLink.parentElement.parentElement;
        const typeLink = parentElement.querySelector('table table tr:nth-child(3) td p a');
        const name = typeLink.textContent;
        return name;
    })
    await page.close();
    return { type: tagType, code: listing.code, name: listing.name };
}

const getMessages = async (browser: puppeteer.Browser): Promise<Listing[]> => {
    const page = await browser.newPage();
    await page.goto('https://www.onixs.biz/fix-dictionary/4.4/msgs_by_msg_type.html');
    await page.waitForSelector('table.fixTableBorder table tbody tr');
    const messages = await page.evaluate(() => {
        const rows = Array.from(document.querySelectorAll('table.fixTableBorder table tbody tr'));
        return rows
            .slice(1)
            .map(m => {
                //Reminder, nth-child is 1-indexed.
                const messageCode = m.querySelector('td:nth-child(1) a');
                const messageName = m.querySelector('td:nth-child(2) a');
                return {code: messageCode?.innerHTML, name: messageName?.innerHTML, url: messageCode?.getAttributeNode('href')?.value};
            });
    });
    await page.close();
    return messages;
};

const getMessageStructure = async (browser: puppeteer.Browser, msg: Listing): Promise<MessageStructure> => {
    const page = await browser.newPage();
    await page.goto(`https://www.onixs.biz/fix-dictionary/4.4/${msg.url}`);
    await page.waitForSelector('table.fixTableBorder table tbody tr');
    const messages = await page.evaluate(() => {
        const rows = Array.from(document.querySelectorAll('table.fixTableBorder table tbody tr'));
        const tagRows = rows
            .slice(1)
            //don't include the header and footer rows
            .filter(m => !m.querySelector('td:nth-child(1)')?.textContent.includes('Message'));
        const requiredTags = tagRows.filter(m => m.querySelector('td:nth-child(3)')?.textContent.includes('Y')).map(m => parseInt(m.querySelector('td:nth-child(1)')?.textContent));
        const optionalTags = tagRows.filter(m => m.querySelector('td:nth-child(3)')?.textContent.includes('N')).map(m => parseInt(m.querySelector('td:nth-child(1)')?.textContent));
        return { requiredTags, optionalTags};
    });

    // await page.$$eval('table.fixTableBorder tbody tr', rows => console.log(rows.length)
    //Skip the first row, it's a header.
    // .slice(1)
    //Each of these is a message row.
    // .forEach(m => {
    //     //Reminder, nth-child is 1-indexed.
    //     const messageCode = m.querySelector('td:nth-child(1) a');
    //     const messageName = m.querySelector('td:nth-child(2) a');
    //     // console.log(`${messageCode} - ${messageName}`);
    // })
    await page.close();
    return { code: msg.code, name: msg.name, optionalTags: messages.optionalTags, requiredTags: messages.requiredTags };
};

puppeteer.launch().then(async (browser: puppeteer.Browser) => {
    //Move to config file
    console.log('Getting Tags');
    let tagTypes: { [key: number]: TagDetail };
    if (fs.existsSync('./tags.json')) {
        tagTypes = JSON.parse(fs.readFileSync('./tags.json', 'utf8'));
    }
    else {
        tagTypes = {};
        const tags = await getTags(browser);
        for (let i = 0; i < tags.length; i++) {
            console.log(`Getting Tag Type for ${tags[i].code}`);
            const tagType = await getTagType(browser, tags[i]);
            //To prevent rate limiting, wait a bit between requests.
            await wait(1000);
            tagTypes[tagType.code] = tagType;
        }
        fs.writeFileSync('./tags.json', JSON.stringify(tagTypes, null, 2));
    }
    let messageDetails: MessageStructure[];
    console.log('Getting Messages');
    if (fs.existsSync('./messages.json')) {
        messageDetails = JSON.parse(fs.readFileSync('./messages.json', 'utf8'));
    } else {
        messageDetails = [];
        const messages = await getMessages(browser);
        for (let i = 0; i < messages.length; i++) {
            const message = messages[i];
            //To prevent rate limiting, wait a bit between requests.
            await wait(1000);
            messageDetails.push(await getMessageStructure(browser, message));
        }
        fs.writeFileSync('./messages.json', JSON.stringify(messageDetails, null, 2));
    }
    messageDetails.forEach(m => {
        const cleanedMessageName = m.name.replace(/\(.*\)| /g, '').replace(/[^a-zA-Z0-9]/g, '');
        const messageCode = m.code;
        const optionalTags: TagDetail[] = m.optionalTags.map(t => tagTypes[t]);
        const requiredTags: TagDetail[] = m.requiredTags.map(t => tagTypes[t]);
        let fileContent = 
        `
namespace FIX.Models;
[MessageCode("${messageCode}")]
public class ${cleanedMessageName}
{
`;
        requiredTags.filter(t => t != null && t != undefined).forEach(t => {
            const type = <boolean>Object.prototype.hasOwnProperty.call(typeMap, t?.type) ? typeMap[t.type] : t.type;
            fileContent += `    
    [FieldNumber("${t.code}")]
    public ${type} ${t.name} { get; set; }
`;
    });
        optionalTags.filter(t => t != null && t != undefined).forEach(t => {
            const type = <boolean>Object.prototype.hasOwnProperty.call(typeMap, t?.type) ? typeMap[t.type] : t.type;
            fileContent += `    
    [FieldNumber("${t.code}")]
    public ${type}? ${t.name} { get; set; }
`;
        });
        fileContent += `
}
`;
        fs.writeFileSync(`../../FIX.Models/Messages/${cleanedMessageName}.cs`, fileContent);
    });     
    console.log(JSON.stringify(messageDetails));
    await browser.close();
});