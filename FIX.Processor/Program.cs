using CommandLine;
using CommandLine.Text;
using FIX.Models;
using FIX.Processor;

CommandLine.Parser.Default

    .ParseArguments<Options>(args)
    
    .MapResult(
        (Options opts) => ProcessStream.Execute(opts),
        errs => 1);
