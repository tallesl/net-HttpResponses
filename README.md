# HttpResponses

[![][build-img]][build]
[![][nuget-img]][nuget]

[build]:     https://ci.appveyor.com/project/TallesL/net-httpresponses
[build-img]: https://ci.appveyor.com/api/projects/status/github/tallesl/net-httpresponses?svg=true
[nuget]:     https://www.nuget.org/packages/HttpResponses
[nuget-img]: https://badge.fury.io/nu/HttpResponses.svg

## Usage

This

```cs
using HttpResponsesLibrary;

throw HttpResponses.BadRequest("Your fault!");
```

instead of

```cs
throw new HttpResponseException(
    new HttpResponseMessage(HttpStatusCode.BadRequest)
    {
        ReasonPhrase = "Your fault!"
    }
);
```
