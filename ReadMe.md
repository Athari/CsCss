# *CsCss: .NET CSS Parser*

https://github.com/Athari/CsCss

CsCss is a **CSS Parser** written in **C#**, based on **Mozilla Firefox 22** code.

At the time of writing, it is the only C# CSS Parser capable of parsing all varieties of CSS supported by modern browsers. However, the choice of the library is not clear-cut, as some important features are missing. See below for details.

The library should be considered alpha-quality, as most of its features are not tested neither by tests no in real world. If you notice any issues, please report them!

Features
========

* Supports parsing of all CSS rules, properties, values etc. supported by Mozilla Firefox. Mozilla-specific extensions (`-moz-*`) are supported too.
* Two modes of compatibility: `FullStandards` (default) and `Quirks` (units are optional etc.).
* Values are parsed into complex structures. For example, shortcut `background` property is converted into multiple longhand properties, one of which, `background-image`, is represented by a list of values corresponding to multiple backgrounds; each value in the list can be a URL or a gradient structure; in case of a gradient it contains a list of gradient stops.
* Error detection and handling according to CSS specification. Parsing will not stop if any unsupported feature is used in the CSS file, parser will just skip to the next declaration.
* Detailed error logging. All warning messages about unsupported or invalid CSS properties or syntax are logged into a `TraceSource` named `Alba.CsCss.CssParser` and are reported as event on `CssLoader.ParsingError`.
* Installation via [NuGet](https://www.nuget.org/packages/Alba.CsCss/) with debugging symbols and sources via [SymbolSource](http://www.symbolsource.org/Public/Metadata/NuGet/Project/Alba.CsCss/).

Not supported (ToDo)
====================

* Different encodings. You need to convert string to Unicode before passing it to `CssLoader`.
* Modifying of a parsed style sheet and serializing it back into string.
* Document Object Model CSS. DOM methods do not comply with C# coding standards, so the necessity is questionable.
* Prefixed and vendor-specific CSS properties (-webkit-*, -ms-*, -o-*, zoom etc.) are ignored.
* Unit tests are almost non-existent. Tests for CSS from Firefox are written in JavaScript and as such are very problematic to convert to C#.

Examples
========

##### Getting color of H1 header style defined in a CSS file
Two URLs are specified: the first one is used for logging puposes; the second one is used as a base for resolving relative `url()` expressions.
```cs
CssStyleSheet css = new CssLoader().ParseSheet("h1, h2 { color: #123; }",
    new Uri("http://example.com/sheet.css"), new Uri("http://example.com/"));
Console.WriteLine(css.SheetUri); // http://example.com/sheet.css
// Get color property (equivalent code)
Console.WriteLine(css.StyleRules.Single().Declaration.Color.Color.R); // 17
Console.WriteLine(css.Rules.OfType<CssStyleRule>().Single().Declaration
                               .GetValue(CssProperty.Color).Color.R); // 17
// Get h1 selector
Console.WriteLine(css.StyleRules.Single().SelectorGroups.First().Selectors.Single().Tag);
```

##### Extracting all URLs from a CSS file *(using tokenizer)*
This method will not analyze wether CSS file is valid, it will merely find all `url()` expressions.
```cs
List<string> uris = new CssLoader().GetUris(source).ToList();
```

##### Extracting all URLs from a CSS file *(using parser)*
This method will extract URLs only from valid CSS expressions. It most closely matches behavior of web browsers.
```cs
CssStyleSheet css = new CssLoader().ParseSheet(source, sheetUri, baseUri);
// Get rules of CssStyleRule type on all levels (including style rules inside media rules)
List<string> uris = css.AllStyleRules
    // Get property-value pairs, both non-important and important (marked with !important)
    .SelectMany(styleRule => styleRule.Declaration.AllData)
    // A property can be a list of values (background-image, for example, contains a list of URLs)
    .SelectMany(prop => prop.Value.Unit == CssUnit.List ? prop.Value.List : new[] { prop.Value })
    // Filter values of CssUrlValue type
    .Where(val => val.Unit == CssUnit.Url)
    // Get unresolved URLs (you can use Uri property to get resolved URLs)
    .Select(val => val.OriginalUri)
    .ToList();
```

Requirements
============

* .NET 3.5

Installation
============

1. Install using [NuGet](http://docs.nuget.org/docs/start-here/installing-nuget):

        PM> Install-Package Alba.CsCss

2. Build from sources:

    1. Download sources from [GitHub](https://github.com/Athari/CsCss)
    2. Add `Alba.CsCss/Alba.CsCss.csproj` project to your solution.

Architecture
============

Conversion
----------

The major part of the library is ported by applying numerous regular expressions to original C++ code. C++ code and T4 files with regular expressions are included in the project (but are not included in the compiled DLL). The plan is to keep the code maintainable — when new version of Firefox is released, only minor modifications should be necessary, without trying to match converted code with new original code. Time will tell wether the idea is good.

Only parts which are expected to update regularly are converted with regular expressions. Parts of code which are considered relatively stable (style sheets, value types etc.) or are unpractical to convert with regex (unions, operator new overriding etc.), are rewritten manually.

Currently the biggest file (`nsCSSParser.cpp`/`CssParser.conv.cs`) containing around 10000 lines is converted using 400 lines of regular expressions (4%). Statistics for small files are worse. It helps a lot that Mozilla naming conventions for variables are very strict and pointer arithmetic is not heavily used. However, almost all public classes had to be renamed, as well as most enum values, to comply with C# coding standards.

Building from sources
---------------------

Projects:
* `Alba.CsCss` — the library itself. Has no dependencies except .NET. If library is included in another solution, only this project is necessary.
* `Alba.CsCss.Tests` — "unit" tests (more like integration tests). Very few.
* `Alba.Framework` — personal framework. Debug version of the assembly must be built to be able to run T4 files. Necessary only if you want to modify source code transformations.
* `Alba.Framework.CodeGeneration` — T4 part of the personal framework. Must be built under Administrator account (installs `AttachT4` custom tool similar to T4 Toolbox's `T4ScriptFileGenerator`). Necessary if you want T4 transformations to be applied when original source files are updated, or want ot add new source files.
* `Alba.Framework.Testing` — testing part of the personal framework. Used in tests.

License
=======
[Mozilla Public License](http://www.mozilla.org/MPL/2.0/)

[TL;DR](http://www.tldrlegal.com/license/mozilla-public-license): As long as you include copyright notice, you can do whatever you want, but any *source code file* licensed under MPL must remain under MPL and freely available in source form.

CSS icon by [David Vignoni](http://www.icon-king.com/).

Links
=====

##### Alba.CsCss:
* [**GitHub** project](https://github.com/Athari/CsCss) — source code, issue tracker
* [**NuGet** package](https://www.nuget.org/packages/Alba.CsCss/) — binary package download
* [**SymbolSource** package](http://www.symbolsource.org/Public/Metadata/NuGet/Project/Alba.CsCss/) — source code package download
* [**CodeProject** article](http://www.codeproject.com/Articles/643493/Mozilla-Firefox-CSS-Parser-Ported-to-Csharp) — various details, discussion
* [**Habrahabr** article](http://habrahabr.ru/post/190820/) *(Russian)* — various details, discussion

##### Parsing CSS:
* [**ExCSS**](https://github.com/TylerBrinks/ExCSS) — another CSS parser for .NET. Stops parsing after some expressions. Analysis of expressions is much simpler (they are respresented as a list of terms). However, it supports modification, serialization to string, and is much more lightweight.

##### Parsing HTML:
* [**CsQuery**](https://github.com/jamietre/CsQuery) — jQuery port for .NET (HTML parser + fluent queries). Relies on HTML parser (see below) used in Mozilla Firefox, so very reliable.
* [HtmlParserSharp](https://github.com/jamietre/HtmlParserSharp) — validator.nu HTML parser port for .NET. Port of validator.nu code to C++ is used in Mozilla Firefox, so parsing is as good as it can get.
* [Html Agility Pack](http://htmlagilitypack.codeplex.com/) — older HTML parser. Fails to correctly parse even valid HTML4 code (optional closing tags), has no built-in fluent queries.
* [Fizzler](http://code.google.com/p/fizzler/) — jQuery port for .NET based on Html Agility Pack. Less featureful than CsQuery.
