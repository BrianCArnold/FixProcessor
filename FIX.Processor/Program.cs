using CommandLine;
using CommandLine.Text;
using FIX.Models;
using FIX.Processor;

var parser = CommandLine.Parser.Default;

var parseResult = parser.ParseArguments<ProcessOptions>(args);


var result = parseResult.MapResult(
    (ProcessOptions opts) => new MessageMediator(opts).Execute(),
    errs => 1);

