namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 301
        /// (the requested information has been moved to the URI specified in the Location header)
        /// </summary>
        public static HttpResponseException Moved()
        {
            return new HttpResponseException(HttpStatusCode.Moved);
        }

        /// <summary>
        /// HTTP status 301
        /// (the requested information has been moved to the URI specified in the Location header)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Moved(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Moved) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 301
        /// (the requested information has been moved to the URI specified in the Location header)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Moved(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Moved);
        }

        /// <summary>
        /// HTTP status 301
        /// (the requested information has been moved to the URI specified in the Location header)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Moved<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Moved, content);
        }

        /// <summary>
        /// HTTP status 301
        /// (the requested information has been moved to the URI specified in the Location header)
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
        public static HttpResponseMessage Moved<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Moved(HttpStatusCode.Moved);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
