using CommandLine;
using CommandLine.Text;
using FIX.Models;
using FIX.Processor;

var parser = CommandLine.Parser.Default;

var parseResult = parser.ParseArguments<ProcessOptions>(args);


var result = parseResult.MapResult(
    (ProcessOptions opts) => {
        var messageMediator = new MessageMediator(opts);
        return messageMediator.Execute();
    },
    errs => 1);

