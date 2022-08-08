using CommandLine;
namespace FIX.Processor;

[Verb("process", false, HelpText = "Process a stream of messages", Hidden = false)]
public class ProcessOptions
{

    [Option('v', "verbose", Required = false, HelpText = "Prints informational messages to standard output (default: false)")]
    public bool Verbose { get; set; } = false;

    [Option('s', "source", Required = true, HelpText = "The source to process. (File|Stdin)")]
    public SourceType Source { get; set; }

    [Option('f', "file", Required = false, HelpText = "The file to process. (defaults: Fix.Sample.txt)")]
    public string File { get; set; } = "Fix.Sample.txt";

    [Option('d', "delimiter", Required = false, HelpText = "Which delimiter to use in place of SOH. (default: '|')")]
    public char Delimiter { get; set; } = '|';

    [Option('c', "checksum", Required = false, HelpText = "Treats the delimiter as SOH for checksum. (default: true)")]
    public bool TreatDelimiterAsSOHForChecksum { get; set; } = true;

    [Option('x', "disable-checksum", Required = false, HelpText = "Disables checksum validation. (default: false)")]
    public bool DisableChecksum { get; set; } = false;

    [Option('w', "wait", Required = false, HelpText = "Number of milliseconds to wait between processing messages. (default: 0)")]
    public int WaitTime { get; set; } = 0;

    [Option('o', "disable-sequence-check", Required = false, HelpText = "Disable Sequence Number Check Warning. (default: false)")]
    public bool DisableSequenceCheck { get; set; } = false;

    [Option('e', "hide-errors", Required = false, HelpText = "Hide Specific Error Messages. (default: false)")]
    public bool HideErrors { get; set; } = false;
}