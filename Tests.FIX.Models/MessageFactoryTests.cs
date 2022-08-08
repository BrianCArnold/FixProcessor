using System.Text;

namespace Tests.FIX.Models;

public class MessageFactoryTests
{
    [Fact]
    public void ParseLogonMessage()
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

        
        ((LogonMessage)fixMessage.Body).EncryptMethod.Value.Should().Be(0);
        ((LogonMessage)fixMessage.Body).HeartBtInt.Value.Should().Be(30);

        fixMessage.Validated.Should().BeTrue();        

    }

    [Fact]
    public void ParseExecutionReportMessageWithContraBrokers()
    {
        string srcString = "8=FIX.4.2|9=338|35=8|128=INCA|34=697|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:00:36|17=0700025YF|20=0|150=2|39=2|37=76ZTI2SDBZCC|11=EE5D9B253DF347A|1=396CCS101|55=DOCU|202=130.00|201=0|200=202112|205=03|167=OPT|77=O|54=2|38=1|44=0.67|59=3|439=396|32=1|31=0.67|151=0|14=1|6=0.67|60=20211203-15:00:36.798|9730=R|382=1|375=551|337=CDRG|9882=PP|7694=C|10=136|".ChangeStringToUseSOHChar();
        byte[] messageBytes = Encoding.UTF8.GetBytes(srcString);
        var fixStream = new MemoryStream(messageBytes);

        var messageParser = new FixMessageParser();

        var fixMessage = messageParser.ParseFixMessage(fixStream);

        fixMessage.Header.BeginString.Value.Should().Be("FIX.4.2");
        fixMessage.Header.BodyLength.Value.Should().Be(338);
        fixMessage.Header.MsgType.Value.Should().Be("8");
        fixMessage.Header.SenderCompID.Value.Should().Be("BATS");
        fixMessage.Header.TargetCompID.Value.Should().Be("INCA");
        fixMessage.Header.MsgSeqNum.Value.Should().Be(697);
        fixMessage.Header.SendingTime.Value.Should().Be("20211203-15:00:36");
        fixMessage.Header.SenderSubID.Value.Should().Be("PROD");
        fixMessage.Header.TargetSubID.Value.Should().Be("0028");
        var msg = fixMessage.Body.As<ExecutionReportMessage>();
        fixMessage.Body.As<ExecutionReportMessage>().NoContraBrokers.Value.Should().Be(1);
        fixMessage.Body.As<ExecutionReportMessage>().ContraBrokersCollection.LongCount().Should().Be(fixMessage.Body.As<ExecutionReportMessage>().NoContraBrokers.Value);

        fixMessage.Validated.Should().BeTrue();        

    }


    [Fact]
    public void ParseExecutionReportMessageWithMultipleContraBrokers()
    {
        string srcString = "8=FIX.4.2|9=338|35=8|128=INCA|34=697|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:00:36|17=0700025YF|20=0|150=2|39=2|37=76ZTI2SDBZCC|11=EE5D9B253DF347A|1=396CCS101|55=DOCU|202=130.00|201=0|200=202112|205=03|167=OPT|77=O|54=2|38=1|44=0.67|59=3|439=396|32=1|31=0.67|151=0|14=1|6=0.67|60=20211203-15:00:36.798|9730=R|382=2|375=552|337=CDQE|375=551|337=CDRG|9882=PP|7694=C|10=250|".ChangeStringToUseSOHChar();
        byte[] messageBytes = Encoding.UTF8.GetBytes(srcString);
        var fixStream = new MemoryStream(messageBytes);

        var messageParser = new FixMessageParser();

        var fixMessage = messageParser.ParseFixMessage(fixStream);

        fixMessage.Header.BeginString.Value.Should().Be("FIX.4.2");
        fixMessage.Header.BodyLength.Value.Should().Be(338);
        fixMessage.Header.MsgType.Value.Should().Be("8");
        fixMessage.Header.SenderCompID.Value.Should().Be("BATS");
        fixMessage.Header.TargetCompID.Value.Should().Be("INCA");
        fixMessage.Header.MsgSeqNum.Value.Should().Be(697);
        fixMessage.Header.SendingTime.Value.Should().Be("20211203-15:00:36");
        fixMessage.Header.SenderSubID.Value.Should().Be("PROD");
        fixMessage.Header.TargetSubID.Value.Should().Be("0028");
        var msg = fixMessage.Body.As<ExecutionReportMessage>();
        fixMessage.Body.As<ExecutionReportMessage>().ContraBrokersCollection.LongCount().Should().Be(fixMessage.Body.As<ExecutionReportMessage>().NoContraBrokers);

        fixMessage.Validated.Should().BeTrue();        

    }
}