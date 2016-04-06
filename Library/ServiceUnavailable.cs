namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 503
        /// (the server is temporarily unavailable, usually due to high load or maintenance)
        /// </summary>
        public static HttpResponseException ServiceUnavailable()
        {
            return new HttpResponseException(HttpStatusCode.ServiceUnavailable);
        }

        /// <summary>
        /// HTTP status 503
        /// (the server is temporarily unavailable, usually due to high load or maintenance)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException ServiceUnavailable(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.ServiceUnavailable) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 503
        /// (the server is temporarily unavailable, usually due to high load or maintenance)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage ServiceUnavailable(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.ServiceUnavailable);
        }

        /// <summary>
        /// HTTP status 503
        /// (the server is temporarily unavailable, usually due to high load or maintenance)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage ServiceUnavailable<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.ServiceUnavailable, content);
        }

        /// <summary>
        /// HTTP status 503
        /// (the server is temporarily unavailable, usually due to high load or maintenance)
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
        public static HttpResponseMessage ServiceUnavailable<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.ServiceUnavailable(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
