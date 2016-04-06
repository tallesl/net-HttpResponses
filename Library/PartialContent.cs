namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
        /// </summary>
        public static HttpResponseException PartialContent()
        {
            return new HttpResponseException(HttpStatusCode.PartialContent);
        }

        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException PartialContent(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.PartialContent) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage PartialContent(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.PartialContent);
        }

        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage PartialContent<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.PartialContent, content);
        }

        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
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
        public static HttpResponseMessage PartialContent<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.PartialContent(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
