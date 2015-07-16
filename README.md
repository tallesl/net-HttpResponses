# HttpResponses

[![][nuget-img]][nuget]

[nuget]:     http://badge.fury.io/nu/HttpResponses
[nuget-img]: https://badge.fury.io/nu/HttpResponses.png

This

```cs
using HttpResponseExceptions;

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
