namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 407
        /// (the requested proxy requires authentication)
        /// </summary>
        public static HttpResponseException ProxyAuthenticationRequired()
        {
            return new HttpResponseException(HttpStatusCode.ProxyAuthenticationRequired);
        }

        /// <summary>
        /// HTTP status 407
        /// (the requested proxy requires authentication)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException ProxyAuthenticationRequired(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.ProxyAuthenticationRequired)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 407
        /// (the requested proxy requires authentication)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage ProxyAuthenticationRequired(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.ProxyAuthenticationRequired);
        }

        /// <summary>
        /// HTTP status 407
        /// (the requested proxy requires authentication)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage ProxyAuthenticationRequired<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.ProxyAuthenticationRequired, content);
        }

        /// <summary>
        /// HTTP status 407
        /// (the requested proxy requires authentication)
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
        public static HttpResponseMessage ProxyAuthenticationRequired<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.ProxyAuthenticationRequired(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
