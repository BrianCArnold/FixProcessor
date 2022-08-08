import { URL } from 'url';
import * as fs from 'fs';
import * as puppeteer from 'puppeteer';
import { typeMap } from './FixToDotNetTypeMap';

type Listing = {
    code: string;
    name: string;
    url: string;
    deprecated: boolean;
};
type TagDetail = {
    code: string;
    type: string;
    name: string;
    deprecated: boolean;
}
type PartialStructureTag = {
    id: number;
    children: StructureTag[];
    required: boolean;
}
type StructureTag = {
    id: number;
    name: string;
    children: StructureTag[];
    required: boolean;
    type: string;
};

type MessageStructure = {
    code: string;
    name: string;
    tags: StructureTag[];
    deprecated: boolean;
};

const getTags = async (browser: puppeteer.Browser): Promise<Listing[]> => {
    const page = await browser.newPage();
    await page.goto('https://www.onixs.biz/fix-dictionary/4.2/fields_by_tag.html');
    await page.waitForSelector('table.fixTableBorder table tbody tr');
    
    const tags = await page.evaluate(() => {
        const rows = Array.from(document.querySelectorAll('table.fixTableBorder table tbody tr'));
        return rows
            .slice(1)
            .map(m => {
                //Reminder, nth-child is 1-indexed.
                const tagCode = m.querySelector('td:nth-child(1) a');
                const tagName = m.querySelector('td:nth-child(2) a');
                const tagNameString = tagName?.textContent;
                const cleanedTagName = tagNameString.replace(/\(.*\)| /g, '').replace(/[^a-zA-Z0-9]/g, '');
                const isDeprecated = tagNameString.includes('('); //Could be "replaced", "obsoleted", "deprecated", but always appears to be in parentheses.
                return {code: tagCode?.innerHTML, name: cleanedTagName, url: tagCode?.getAttributeNode('href')?.value, deprecated: isDeprecated};
            });
    });
    await page.close();
    return tags;
}


const getTagType = async (browser: puppeteer.Browser, listing: Listing): Promise<TagDetail> => {
    const page = await browser.newPage();
    console.log('Getting Tag Type for ' + listing.code);
    console.log('Going to URL: ' + `https://www.onixs.biz/fix-dictionary/4.2/${listing.url}`);
    await page.goto(`https://www.onixs.biz/fix-dictionary/4.2/${listing.url}`);
    const tagType = await page.evaluate(() => {
        const usedInLink = document.querySelector('a[href="#UsedIn"]');
        const parentElement = usedInLink.parentElement.parentElement;
        const typeLink = parentElement.querySelector('table table tr:nth-child(3) td p a');
        const name = typeLink.textContent;
        return name;
    })
    await page.close();
    return { type: tagType, code: listing.code, name: listing.name, deprecated: listing.deprecated };
}

const getMessages = async (browser: puppeteer.Browser): Promise<Listing[]> => {
    const page = await browser.newPage();
    await page.goto('https://www.onixs.biz/fix-dictionary/4.2/msgs_by_msg_type.html');
    await page.waitForSelector('table.fixTableBorder table tbody tr');
    const messages = await page.evaluate(() => {
        const rows = Array.from(document.querySelectorAll('table.fixTableBorder table tbody tr'));
        return rows
            .slice(1)
            .map(m => {
                //Reminder, nth-child is 1-indexed.
                const messageCode = m.querySelector('td:nth-child(1) a');
                const messageName = m.querySelector('td:nth-child(2) a');
                return {code: messageCode?.innerHTML, name: messageName?.innerHTML, url: messageCode?.getAttributeNode('href')?.value, deprecated: messageName?.innerHTML.includes('(') };
            });
    });
    await page.close();
    return messages;
};

const getMessageStructure = async (browser: puppeteer.Browser, msg: Listing, tagTypes: { [key: number]: TagDetail }): Promise<MessageStructure> => {
    const page = await browser.newPage();
    await page.goto(`https://www.onixs.biz/fix-dictionary/4.2/${msg.url}`);
    await page.waitForSelector('table.fixTableBorder table tbody tr');
    console.log('Getting Message Structure for ' + msg.url);
    const partialTags = await page.evaluate(() => {
        const h3Elements = Array.from(document.querySelectorAll('h3'));
        let structureH3: HTMLHeadingElement = null;
        for (const h3 of h3Elements) {
            if (h3.innerHTML.includes('Structure')) {
                structureH3 = h3;
                break;
            }
        }
        const tagRows = Array.from(structureH3.nextElementSibling.querySelectorAll('table.fixTableBorder table tbody tr')).slice(1);
            //don't include the header and footer rows
            // .filter(m => !m.querySelector('td:nth-child(1)')?.textContent.includes('Message'));
        const tags: PartialStructureTag[] = [];
        for (const row of tagRows) {
            let currentTagArray = tags;
            const cols = Array.from(row.querySelectorAll('td'));
            
            while (cols[0].innerHTML.includes('=&gt;')) {
                currentTagArray = currentTagArray[currentTagArray.length - 1].children;
                cols.shift();
            }
            if (cols[0].innerHTML.match(/^\d+$/)) { //This is a tag.
                const tagCode = parseInt(cols[0].innerHTML);
                cols.shift();
                cols.shift();
                const req = cols[0].innerHTML.includes('Y');
                currentTagArray.push({id: tagCode, children: [], required: req});
            }
        }
        // const requiredTags = tagRows.filter(m => m.querySelector('td:nth-child(3)')?.textContent.includes('Y')).map(m => parseInt(m.querySelector('td:nth-child(1)')?.textContent));
        // const optionalTags = tagRows.filter(m => m.querySelector('td:nth-child(3)')?.textContent.includes('N')).map(m => parseInt(m.querySelector('td:nth-child(1)')?.textContent));
        return tags;
    });
    const updateTag = (t: PartialStructureTag): StructureTag => ({
        id: t.id,
        required: t.required,
        children: t.children.map(u => updateTag(u)),
        name: tagTypes[t.id]?.name,
        type: tagTypes[t.id]?.type,
    });
    const messageTags = partialTags.map(t => updateTag(t));
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
    return { code: msg.code, name: msg.name, tags: messageTags, deprecated: msg.deprecated };
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
            // await wait(1000);
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
        const messages = (await getMessages(browser)).concat([{code: null, name: 'StandardHeader', url: 'compBlock_StandardHeader.html', deprecated: false}, 
        {code: null, name: 'StandardTrailer', url: 'compBlock_StandardTrailer.html', deprecated: false}]);
        for (let i = 0; i < messages.length; i++) {
            const message = messages[i];
            //To prevent rate limiting, wait a bit between requests.
            // await wait(1000);
            messageDetails.push(await getMessageStructure(browser, message, tagTypes));
        }
        fs.writeFileSync('./messages.json', JSON.stringify(messageDetails, null, 2));
    }
    messageDetails.forEach(m => {
        let cleanedMessageName = m.name.replace(/\(.*\)| /g, '').replace(/[^a-zA-Z0-9]/g, '');
        const messageCode = m.code;
        
        let fileContent = 
        `namespace FIX.Models;
`;
        if (m.deprecated) {
        fileContent += `[Obsolete]`;
        }
        if (messageCode) {
            cleanedMessageName += "Message";
            fileContent += `
[MessageCode("${messageCode}")]`;
        }
        fileContent += `
public class ${cleanedMessageName} : FixMessage<${cleanedMessageName}>
{
`;
        const processTags = (tags: StructureTag[], indentLevel: number = 1) => {
            const indentation = "  ".repeat(indentLevel);
            tags.sort((a,b) => (a.required ? 1 : 0) > (b.required ? 1 : 0) ? -1 : 1).forEach(t => {
                const type = <boolean>Object.prototype.hasOwnProperty.call(typeMap, t.type) ? typeMap[t.type] : t.type;
                fileContent += `    
${indentation}[FieldNumber(${t.id})]`;
                if (t.children.length > 0) {
                    fileContent += `    
${indentation}[FieldChildrenNumbers(${t.children.map(c => c.id).join(', ')})]`;
                }
                if (t.required) {
                    fileContent += `    
${indentation}[RequiredField]`;
                }
fileContent += `
${indentation}public ${type} ${t.name} { get; set; }
`;
                if (t.children.length > 0) {
                    fileContent += `
${indentation}[FieldNumberTarget(${t.id})]
${indentation}public ICollection<${t.name.replace(/^No/, '')}Class> ${t.name.replace(/^No/, '')} { get; set; } = new List<${t.name.replace(/^No/, '')}Class>();
${indentation}[FieldNumberTarget(${t.id})]
${indentation}public class ${t.name.replace(/^No/, '')}Class
${indentation}{`;
                    processTags(t.children, indentLevel + 1);
                    fileContent += `${indentation}}
`;
                }
            });
        };
        processTags(m.tags);
        fileContent += `
}
`;
        
        fs.writeFileSync(`../../FIX.Models/Messages/${cleanedMessageName}.cs`, fileContent);
        
    });     
    console.log(JSON.stringify(messageDetails));
    await browser.close();
});