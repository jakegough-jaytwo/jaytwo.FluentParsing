# jaytwo.FluentParsing

[![NuGet version (jaytwo.FluentParsing)](https://img.shields.io/nuget/v/jaytwo.FluentParsing.svg?style=flat-square)](https://www.nuget.org/packages/jaytwo.FluentParsing/)

A Fluent API approach to parsing.

## Installation

Add the NuGet package

```
PM> Install-Package jaytwo.FluentParsing
```

## Usage

There are only a few details to keep in mind.  You begin the fluent chain by calling `.Parse()`, and from there you can 
jump straight into `.Int()`, `.Double()`, `.Uri()`, etc.  You can also choose-your-own-adventure paths of `.Try()`
or `.Nullable()`.

### `.Parse()`

```csharp
// parses string into a double as expected
var parsed = "123.45".Parse().Try().Double();

// all of these throw an exception
var parsed = "abc".Parse().Double(); 
var parsed = "".Parse().Double();
var parsed = ((string)null).Parse().Double();
```

### `.Try()`

This produces a nullable version of the desired target type (e.g. `double?`/`Nullable<double>`, etc.).  It swallows
all exceptions and instead just returns null if the parse isn't successful.

```csharp
// parses string into a double as expected
var parsed = "123.45".Parse().Try().Double();

// all of these return null (and don't throw an exception)
var parsed = "abc".Parse().Try().Double(); 
var parsed = "".Parse().Try().Double(); // returns null
var parsed = ((string)null).Parse().Try().Double(); // returns null
```

### `.Nullable()`

This produces a nullable version of the desired target type (e.g. `double?`/`Nullable<double>`, etc.).  It's fine with
parsing `null` and `empty` strings into null, but will still throw an exception if the parse is otherwise invalid.

```csharp
// parses string into a double as expected
var parsed = "123.45".Parse().Nullable().Double();

// throws an exception
var parsed = "abc".Parse().Nullable().Double(); 

// returns null
var parsed = "".Parse().Nullable().Double(); // returns null
var parsed = ((string)null).Parse().Nullable().Double(); // returns null
```

## Supported Types

All the usual suspects are supported: `bool`, `DateTime`, `decimal`, `double`, `float`, `int`, `long`, `short`, `uint`, `ulong`, `ushort`.  
I also included the frequently used (but often neglected) types `BigInteger`, `Enum`, `Guid`, and `Uri`.

Because parsing is than just translation from a string, there are a few operations for binary data also:

__Binary Data to Strings___

```csharp
byte[] helloWorldBytes = new byte[] { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 };

// returns "48656C6C6F20576F726C64"
string hex = helloWorldBytes.Parse().Hex();

// returns "SGVsbG8gV29ybGQ="
string base64 = helloWorldBytes.Parse().Base64();

// returns "Hello World"
string text = helloWorldBytes.Parse().UTF8String();
string text = helloWorldBytes.Parse().String(Encoding.ASCII);
```

__Strings to Binary Data___

```csharp
// all return { 72, 101, 108, 108, 111, 32, 87, 111, 114, 108, 100 }
byte[] bytes = "Hello World".Parse().UTF8Bytes();
byte[] bytes = "Hello World".Parse().Bytes(Encoding.ASCII);
byte[] bytes = "SGVsbG8gV29ybGQ=".Parse().Base64Bytes();
byte[] bytes = "48656C6C6F20576F726C64".Parse().HexBytes();
```

---

Made with &hearts; by Jake
