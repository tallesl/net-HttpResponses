namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 504
        /// (an intermediate proxy server timed out while waiting for a response from another proxy or the origin server)
        /// </summary>
        public static HttpResponseException GatewayTimeout()
        {
            return new HttpResponseException(HttpStatusCode.GatewayTimeout);
        }

        /// <summary>
        /// HTTP status 504
        /// (an intermediate proxy server timed out while waiting for a response from another proxy or the origin server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException GatewayTimeout(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.GatewayTimeout) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 504
        /// (an intermediate proxy server timed out while waiting for a response from another proxy or the origin server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage GatewayTimeout(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.GatewayTimeout);
        }

        /// <summary>
        /// HTTP status 504
        /// (an intermediate proxy server timed out while waiting for a response from another proxy or the origin server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage GatewayTimeout<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.GatewayTimeout, content);
        }

        /// <summary>
        /// HTTP status 504
        /// (an intermediate proxy server timed out while waiting for a response from another proxy or the origin server)
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
        public static HttpResponseMessage GatewayTimeout<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.GatewayTimeout(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
