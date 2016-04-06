namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        public static HttpResponseException HttpVersionNotSupported()
        {
            return new HttpResponseException(HttpStatusCode.HttpVersionNotSupported);
        }

        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException HttpVersionNotSupported(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.HttpVersionNotSupported) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage HttpVersionNotSupported(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.HttpVersionNotSupported);
        }

        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage HttpVersionNotSupported<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.HttpVersionNotSupported, content);
        }

        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage HttpVersionNotSupported<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.HttpVersionNotSupported(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
