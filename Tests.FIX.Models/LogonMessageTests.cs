using System.Text;

namespace Tests.FIX.Models;

public class LogonMessageTests
{

    [Fact]
    public void LoginMessageProcessedCorrectly()
    {
        string srcString = "8=FIX.4.2|9=0020|35=A|49=INCA|56=BATS|34=000000001|52=20211203-13:30:00.632|50=0028|57=PROD|98=0|108=30|10=084|".ChangeStringToUseSOHChar();
        byte[] messageBytes = Encoding.UTF8.GetBytes(srcString);
        var fixStream = new MemoryStream(messageBytes);

        var messageParser = new FixMessageParser();

        var fixMessage = messageParser.ParseFixMessage(fixStream);

        fixMessage.Header.BeginString.Value.Should().Be("FIX.4.2");
        fixMessage.Header.BodyLength.Value.Should().Be(20);
        fixMessage.Header.MsgType.Value.Should().Be("A");
        fixMessage.Header.SenderCompID.Value.Should().Be("INCA");
        fixMessage.Header.TargetCompID.Value.Should().Be("BATS");
        fixMessage.Header.MsgSeqNum.Value.Should().Be(1);
        fixMessage.Header.SendingTime.Value.Should().Be("20211203-13:30:00.632");
        fixMessage.Header.SenderSubID.Value.Should().Be("0028");
        fixMessage.Header.TargetSubID.Value.Should().Be("PROD");

        fixMessage.Body.As<LogonMessage>().EncryptMethod.Value.Should().Be(0);
        fixMessage.Body.As<LogonMessage>().HeartBtInt.Value.Should().Be(30);

        
        fixMessage.ValidityMessages.Count().Should().Be(0);
    }
}