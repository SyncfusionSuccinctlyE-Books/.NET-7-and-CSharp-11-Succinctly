# .NET 7 and C# 11 Succinctly

This is the companion repo for [*.NET 7 and C# 11 Succinctly*](https://www.syncfusion.com/succinctly-free-ebooks/dotnet7-and-csharp11-succinctly) by Dirk Strauss. Published by Syncfusion<sup>®</sup>.

[![cover](https://github.com/SyncfusionSuccinctlyE-Books/.NET-7-and-CSharp-11-Succinctly/blob/main/cover.png)](https://www.syncfusion.com/succinctly-free-ebooks/dotnet7-and-csharp11-succinctly)

## Looking for more _Succinctly_ titles?

Check out the entire library of more than 200 _Succinctly_ ebooks at [https://www.syncfusion.com/succinctly-free-ebooks] (https://www.syncfusion.com/succinctly-free-ebooks).

## Chapter 1: Introducing .NET 7
To understand how we arrived at .NET 7, we should first briefly examine the history of .NET in general.
### About .NET 7
Compared to .NET 6.0, the release of .NET 7.0 was relatively small. It did, however, bring with it performance increases. A thousand performance-impacting pull requests went into the runtime and core libraries. 
### Upgrading existing applications to .NET 7
Upgrading an existing .NET 6.0 project to .NET 7.0 is quite simple.
### The .NET Upgrade Assistant
The .NET Upgrade Assistant is an upgrade tool that assists developers in upgrading their applications to the latest version of .NET.

## Chapter 2: A Closer Look at C# 11
C# 11 is a big release when looking at the new features it introduces. Some of these changes include:
- File-scoped types
- Generic math support
- UTF-8 Literals
- Raw string literals
- Required members
- Generic attributes
- API changes

I look at some of these in more detail in the following sections.

### File-scoped types
C# 11 introduces the file contextual keyword, which is a type modifier.
### Generic math support
New math-related generic interfaces introduced to the base class library in .NET 7.0 means that you can constrain the type parameter of a generic method to be “number-like.” You can, therefore, perform mathematical operations generically.
### UTF-8 literals
UTF-8 is considered the encoding of the web. It's also used in significant parts of the .NET stack. With C# 11, you can mark strings as UTF-8.
### Raw string literals
In C# 11 you can escape the double quotes inside the string by providing three double quotes around the string.
### Required members
Required members give me more control over the classes I create, allowing me to express my intent more clearly to consuming code.
### Generic attributes
In terms of writing better code, using generic attributes makes an enormous difference.
### List patterns
C#11 allows developers to match an array or list against a sequence of patterns. It means that list patterns apply to anything that is countable or has a count property.
### Pattern matching on spans
Pattern matching has allowed developers to test whether a string has a particular constant. This same pattern-matching logic now comes to Span<char> or ReadOnlySpan<char> variables.
### Auto-default struct
C# 11 now ensures that all fields of a struct type are initialized to their respective default values. This is automatically done by the compiler. 

## Chapter 3: ASP.NET Core 7
Chances are, you will work with ASP.NET Core at some point in your career. Whether this is developing a website or an API, ASP.NET Core is at play here. Due to the importance of ASP.NET Core, Microsoft has added a large number of features to the ASP.NET Core platform.
### New features in ASP.NET Core 7
In this section, I look at several new features in ASP.NET Core 7 while discussing a few in detail later in the chapter.
### Rate limiting
ASP.NET Core 7 applications can now configure rate-limiting policies and attach those policies to endpoints in your application.
### Output caching
ASP.NET Core provides developers with various options when it comes to caching. These caching options have also been around for quite some time. These are:
 * In-memory cache
 * Distributed cache
 * Response cache
 * Output caching (new in .NET Core 7)
### Minimal APIs
Minimal APIs rely on top-level statements, and as developers started becoming used to this minimal approach to creating APIs, a few things were still missing. Microsoft, therefore, started maturing the platform to what we now have in .NET 7.

## Chapter 4: Performance Improvements
The performance well has by no means run dry. Even though .NET 6 was fast, and one could imagine that there was little else to do to speed up .NET anymore, along comes .NET 7, with some serious performance improvements.
### LINQ: Improvements to Existing Operations
With .NET 7, these improvements to performance come to LINQ out of the box. It means that merely upgrading your solution from .NET 6 to .NET 7 gives it a performance boost without you having to write a single line of optimization code.
### LINQ: Using the New Order Method
If you face a situation where you need to use OrderBy(x => x), consider using the Order() method instead.
### JSON improvements
.NET Core 3.0 introduced developers to System.Text.Json with a significant investment going into it with .NET 7. 
