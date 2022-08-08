using CommandLine;
using FIX.Models;
using FIX.Processor;

CommandLine.Parser.Default
    .ParseArguments<Options>(args)
    .WithParsed(ProcessFile.Execute);
