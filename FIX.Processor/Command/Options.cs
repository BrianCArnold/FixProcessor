using CommandLine;
namespace FIX.Processor
{
    public class Options
    {
        [Option('v', "verbose", Required = false, HelpText = "Prints all messages to standard output.")]
        public bool Verbose { get; set; } = false;

        [Option('f', "file", Required = false, HelpText = "The file to process.")]
        public string File { get; set; } = "Fix.Sample.txt";

        [Option('s', "stdin", Required = false, HelpText = "Reads from standard input.")]
        public bool Stdin { get; set; } = false;

        [Option('d', "delimiter", Required = false, HelpText = "The output file.")]
        public char Delimiter { get; set; } = '|';

        [Option('c', "checksum", Required = false, HelpText = "Treats the delimiter as SOH for checksum.")]
        public bool TreatDelimiterAsSOHForChecksum { get; set; } = true;
    }
}