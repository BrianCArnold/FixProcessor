using System.Text;

namespace Tests.FIX.Models;

public class LoginMessageTester
{
    [Fact]
    public void HeaderProcessedCorrectly()
    {
        string srcString = "8=FIX.4.2|9=0020|35=A|49=INCA|56=BATS|34=000000001|52=20211203-13:30:00.632|50=0028|57=PROD|98=0|108=30|10=084|";
        var SOHString = srcString.Replace('|', (char)0x01);
        byte[] messageBytes = Encoding.UTF8.GetBytes(SOHString);
        var fixStream = new MemoryStream(messageBytes);
        StandardHeader header = new StandardHeader();
        var fieldQueue = new FixStreamFieldQueue(fixStream);
        header.PopulateMessageFields(fieldQueue);
        header.BeginString.Value.Should().Be("FIX.4.2");
        header.BodyLength.Value.Should().Be(20);
        header.MsgType.Value.Should().Be("A");
        header.SenderCompID.Value.Should().Be("INCA");
        header.TargetCompID.Value.Should().Be("BATS");
        header.MsgSeqNum.Value.Should().Be(1);
        header.SendingTime.Value.Should().Be("20211203-13:30:00.632");
        header.SenderSubID.Value.Should().Be("0028");
        header.TargetSubID.Value.Should().Be("PROD");

    }

    [Fact]
    public void LoginMessageProcessedCorrectly()
    {
        string srcString = "8=FIX.4.2|9=0020|35=A|49=INCA|56=BATS|34=000000001|52=20211203-13:30:00.632|50=0028|57=PROD|98=0|108=30|10=084|";
        var SOHString = srcString.Replace('|', (char)0x01);
        byte[] messageBytes = Encoding.UTF8.GetBytes(SOHString);
        var fixStream = new MemoryStream(messageBytes);
        var fieldQueue = new FixStreamFieldQueue(fixStream);

        StandardHeader header = new StandardHeader();
        header.PopulateMessageFields(fieldQueue);
        
        LogonMessage logonMessage = new LogonMessage();
        logonMessage.PopulateMessageFields(fieldQueue);
        logonMessage.EncryptMethod.Value.Should().Be(0);
        logonMessage.HeartBtInt.Value.Should().Be(30);
        
    }
    
    [Fact]
    public void TrailerProcessedCorrectly()
    {
        string srcString = "8=FIX.4.2|9=0020|35=A|49=INCA|56=BATS|34=000000001|52=20211203-13:30:00.632|50=0028|57=PROD|98=0|108=30|10=084|";
        var SOHString = srcString.Replace('|', (char)0x01);
        byte[] messageBytes = Encoding.UTF8.GetBytes(SOHString);
        var fixStream = new MemoryStream(messageBytes);
        var fieldQueue = new FixStreamFieldQueue(fixStream);

        StandardHeader header = new StandardHeader();
        header.PopulateMessageFields(fieldQueue);
        
        LogonMessage logonMessage = new LogonMessage();
        logonMessage.PopulateMessageFields(fieldQueue);

        StandardTrailer trailer = new StandardTrailer();
        trailer.PopulateMessageFields(fieldQueue);

        
        int.Parse(trailer.CheckSum.Value).Should().Be(fieldQueue.CheckSum);
    }

}