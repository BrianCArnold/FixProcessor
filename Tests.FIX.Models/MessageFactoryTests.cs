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

        fixMessage.ValidityMessages.Count(m=>m.Level == MessageLevel.Error).Should().Be(0);

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

        fixMessage.ValidityMessages.Count(m=>m.Level == MessageLevel.Error).Should().Be(0);

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

        fixMessage.ValidityMessages.Count(m=>m.Level == MessageLevel.Error).Should().Be(0);

    }

    [Fact]
    public void CanProcessNewOrder()
    {
        string srcString = "8=FIX.4.2|9=0265|35=D|49=INCA|56=BATS|34=000003212|52=20211203-15:39:48.055|50=0028|57=PROD|115=INCA|1=396CCS101|11=EF199B245DEA718|21=1|38=7|40=2|44=68.2|54=1|55=TSLA|167=OPT|200=202201|205=21|202=1150|201=1|59=3|60=20211203-15:39:48.052|47=U|77=C|439=396|8000=1136624207752890255|10=029|".ChangeStringToUseSOHChar();
        byte[] messageBytes = Encoding.UTF8.GetBytes(srcString);
        var fixStream = new MemoryStream(messageBytes);

        var messageParser = new FixMessageParser();

        var fixMessage = messageParser.ParseFixMessage(fixStream);
        fixMessage.Header.BeginString.Value.Should().Be("FIX.4.2");

    }
    [Fact]
    public void CanProcessMultipleItemsWithProblems()
    {
        string srcString = @"8=FIX.4.2|9=0020|35=A|49=INCA|56=BATS|34=000000001|52=20211203-13:30:00.632|50=0028|57=PROD|98=0|108=30|10=084|
8=FIX.4.2|9=75|35=A|34=1|49=BATS|50=PROD|56=INCA|57=0028|52=20211203-13:30:00|98=0|108=30|10=181|
8=FIX.4.2|9=63|35=0|34=2|49=BATS|50=PROD|56=INCA|57=0028|52=20211203-13:30:01|10=138|
8=FIX.4.2|9=0238|35=D|49=INCA|56=BATS|34=000000690|52=20211203-15:00:36.797|50=0028|57=PROD|115=INCA|1=396CCS101|11=EE5D9B253DF347A|21=1|38=1|40=2|44=0.67|54=2|55=DOCU|167=OPT|200=202112|205=3|202=130|201=0|59=3|60=20211203-15:00:36.796|47=U|77=O|439=396|10=106|
8=FIX.4.2|9=0151|35=D|34=000000000|1=SPDRT1|11=DB95A6B1070A29C|38=100|40=2|44=266.04|54=1|55=SPY|59=0|60=20181127-16:46:07.996|100=XNYS|9416=A|9303=N|528=A|386=1|336=2|10=028|
8=FIX.4.2|9=295|35=8|128=INCA|34=696|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:00:36|17=S7000O3ASN|20=0|150=0|39=0|37=76ZTI2SDBZCC|11=EE5D9B253DF347A|1=396CCS101|55=DOCU|202=130.00|201=0|200=202112|205=03|167=OPT|77=O|54=2|38=1|44=0.67|59=3|439=396|32=0|31=0|151=1|14=0|6=0|60=20211203-15:00:36.798|9730=R|10=060|
8=FIX.4.2|9=338|35=8|128=INCA|34=697|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:00:36|17=0700025YF|20=0|150=2|39=2|37=76ZTI2SDBZCC|11=EE5D9B253DF347A|1=396CCS101|55=DOCU|202=130.00|201=0|200=202112|205=03|167=OPT|77=O|54=2|38=1|44=0.67|59=3|439=396|32=1|31=0.67|151=0|14=1|6=0.67|60=20211203-15:00:36.798|9730=R|382=1|375=551|337=CDRG|9882=PP|7694=C|10=136|
8=FIX.4.2|9=0265|35=D|49=INCA|56=BATS|34=000003212|52=20211203-15:39:48.055|50=0028|57=PROD|115=INCA|1=396CCS101|11=EF199B245DEA718|21=1|38=7|40=2|44=68.2|54=1|55=TSLA|167=OPT|200=202201|205=21|202=1150|201=1|59=3|60=20211203-15:39:48.052|47=U|77=C|439=396|8000=1136624207752890255|10=029|
8=FIX.4.2|9=0314|35=AB|34=000000011|1=SPDRT1|11=10109A9578A82AAA|100=1|21=1|38=10|40=2|44=-3.98|54=1|55=BA|59=0|167=MLEG|207=XASE|60=20181127-16:46:07.996|204=8|555=2|600=BA|608=OP|609=OPT|611=20181109|612=360|654=EA628EA5B0F8186|623=1|624=2|564=O|600=BA|608=OP|609=OPT|611=20181109|612=362.5|654=EA628EA5B0F8187|623=1|624=2|564=O|10=195|
8=FIX.4.2|9=298|35=8|128=INCA|34=3237|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:39:48|17=SR001NHULO|20=0|150=0|39=0|37=R6ZTI2TXX3H3|11=EF199B245DEA718|1=396CCS101|55=TSLA|202=1150.00|201=1|200=202201|205=21|167=OPT|77=C|54=1|38=7|44=68.20|59=3|439=396|32=0|31=0|151=7|14=0|6=0|60=20211203-15:39:48.108|9730=R|10=044|
8=FIX.4.2|9=342|35=8|128=INCA|34=3238|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:39:48|17=0R0000RIR|20=0|150=1|39=1|37=R6ZTI2TXX3H3|11=EF199B245DEA718|1=396CCS101|55=TSLA|202=1150.00|201=1|200=202201|205=21|167=OPT|77=C|54=1|38=7|44=68.20|59=3|439=396|32=3|31=68.15|151=4|14=3|6=68.15|60=20211203-15:39:48.108|9730=R|382=1|375=10|337=SIMP|9882=PP|7694=M|10=187|
8=FIX.4.2|9=345|35=8|128=INCA|34=3239|49=BATS|56=INCA|50=PROD|57=0028|52=20211203-15:39:48|17=0R0000RIS|20=0|150=2|39=2|37=R6ZTI2TXX3H3|11=EF199B245DEA718|1=396CCS101|55=TSLA|202=1150.00|201=1|200=202201|205=21|167=OPT|77=C|54=1|38=7|44=68.20|59=3|439=396|32=4|31=68.20|151=0|14=7|6=68.1785|60=20211203-15:39:48.108|9730=R|382=1|375=551|337=CEDL|9882=PP|7694=M|10=071|
8=FIX.4.2|9=0308|35=AB|34=000000000|1=H20466|11=AFCDAF7E0FC8141|100=N|21=1|38=50|40=2|44=-11.7|54=1|55=NVDA|59=0|167=MLEG|60=20181127-16:46:07.996|204=0|555=3|600=NVDA|608=OP|609=OPT|611=20200117|612=215|654=EA61EEBE5226038|623=2|624=1|564=O|600=NVDA|608=OP|609=OPT|611=20210115|612=190|654=EA61EEBE5226039|623=1|624=2|564=O|10=078|
8=FIX.4.2|9=0151|35=D|34=000000014|1=SPDRT1|11=DB95A6B1070A29C|9303=Y|38=100|40=2|44=266.04|54=1|55=SPY|59=0|60=20181127-16:46:07.996|100=XNYS|9416=A|9303=N|528=A|386=1|336=2|10=028|
8=FIX.4.2|9=0238|35=D|49=INCA|56=BATS|34=000000690|52=20211203-15:00:36.797|50=0028|57=PROD|115=INCA|1=396CCS101|11=EE5D9B253DF347A|21=1|38=1|40=2|44=1.67|54=2|55=DOCU|167=OPT|200=202112|205=3|202=130|201=0|59=3|60=20211203-15:00:36.796|47=U|77=O|439=396|10=107|
8=FIX.4.2|9=0151|35=D|34=000000000|1=SPDRT1|11=DB95A6B1070A29C|38=100|40=2|44=256.04|54=1|55=SPY|59=0|60=20181127-16:46:07.996|100=XNYS|9416=A|9303=N|528=A|386=1|336=2|10=027|
8=FIX.4.2|9=0151|35=D|34=000000000|1=SPDRT1|11=DB95A6B1070A29C|38=100|40=2|44=256.04|54=1|55=SPY|55=SPY|59=0|60=20181127-16:46:07.996|100=XNYS|9416=A|9303=N|528=A|386=1|336=2|10=027|".ChangeStringToUseSOHChar();
        var messages = srcString.Split(Environment.NewLine);
        ICollection<FixMessage> fixMessages = new List<FixMessage>();
        foreach (var message in messages)
        {
            byte[] messageBytes = Encoding.UTF8.GetBytes(message);
            var messageStream = new MemoryStream(messageBytes);

            var messageParser = new FixMessageParser();
            var parsedMsg = messageParser.ParseFixMessage(messageStream);
            fixMessages.Add(parsedMsg);
        }
        fixMessages.Count.Should().Be(17);

    }
}