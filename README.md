_**The best place to start browsing the code is in FIX.Models/FixMessageParser.cs.**_

# Structure

Most of the relevant code is in FIX.Models. The name is (currently) a misnomer, due to fast development. I will be breaking it out into more appropriate projects.

FIX.Models is broken up into Attributes, Messages, and PropertyTypes, plus FixMessageParser (and it's Options), and FixStreamFieldQueue.


## Attributes

These are used to mark types and properties with information necessary for the processor to infer required fields, repeated blocks, and other information necessary to property interpret a FIX message.

## PropertyTypes

These are a set of types that are used on the properties in each message. They generally map as follows:
- `decimal` (called "floats" in the FIX 4.2 spec)
- `long` (just called "int" in the spec, I used longs since there's no guarantee of range)
- `bool` (technically a `char` in the FIX spec, but represented as a `bool` type to the developer) 
- `byte[]` (referred to as "Data")
- `string` (referred to as "String")
- `char` (referred to as "char")

There are many subtypes of each of these, some of which are only present in FIX 4.3 and up, and as such those are not in use currently.

## Messages

These are extracted directly from the spec at https://www.onixs.biz/fix-dictionary/4.2/index.html, including the repeated message blocks. The base type for each Message and block (including StandardHeader and StandardTrailer) is FixMessageComponent<TMessage>. You will notice that the generic argument is used to allow the implementation on the base class to reference the type of the inherited class, so the inheriting type must specify itself as the generic to the base type.

Each Message type has a `[MessageCode]` attribute that contains the Message Type according the header tag `35`. (If that MessageCode is missing, the specialized body is substituted with the `UnknownMessageComponent` class.) After the header is processed by `PopulateMessageFields`, a dictionary lookup is made to a closure that instantiates the relevant Message object. At this point the `PopulateMessageFields` is called on the Message type, which I'm also calling the "Body". It assigns values to every property in the Message according to the Tag number, looking up the property in a Dictionary that caches the relevant PropertyInfo necessary to update the relevant Property to that Tag.

Upon processing each tag, it also checks to see if there's a Collection associated with that tag, and if so, it checks the number of expected items in the collection, and instatiates each one before calling it's `PopulateMessageFields` method to populate each of the properties it has.

This continues recursively until all expected tags, and custom tags over 5000, are populated on the Body. Then it recursively checks the Body block and all subblocks for any missing Required tags, and emits an error message up to the message builder.

After this is completed, the Trailer is instantiated, and `PopulateMessageFields` is called on it as well.

## FixStreamFieldQueue

This processes each message as a `byte[]`, separating each tag in the message by the `SOH` character. The configuration options in FIX.Processor default to using `|` as the `SOH` character, but initially the `Stream` was changed to actually replace the `|` character with the actual `SOH`, (ASCII/UTF-8: `0x01`). If this is expanded to process data as TCP packets, the processor will need to be configured to process the byte stream with `0x01` as the delimiter.

After each Tag is identified, the tag number and the `byte[]` representation of the value is placed in a `FixField`, and queued into the `public Queue<FixField> Fields` property. This is then processed by the `PopulateMessageFields` methods.

## FixMessageParser

This takes a set of options and provides a method called `ParseFixMessage` which takes a `Stream`. The stream is a single FIX message, expected to a byte stream be in UTF-8/ASCII. The Stream is turned into a Field Queue, which is then processed by the Header block, which is then used to determine which Message Body class is attached to the FixMessage.

## FixMessage

A simple record consisting of the Header, Body, Trailer, and any messages from the Processing (Info, Warnings, Errors).

## ModelGenerator

This is written in Node, and uses Puppeteer to retrieve the list of tags, the types of those tags, and the Message and Component Block definitions, from which the Message Classes are built. It does locally cache the data it retrieves the first time, so you'll need to erase the `dist/` directory if you need to retrieve the data again. It currently manages to handle the `FIX 4.2` spec, however it needs additional work to retrieve the full set of Component Blocks in use in `FIX 4.4`, and presumably, newer versions.

## Fix.Processor

This is mainly just a way to simply call the FixMessageParser. It works basically the same as the Tests in `Tests.FIX.Models`.