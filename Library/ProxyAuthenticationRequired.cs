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
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
