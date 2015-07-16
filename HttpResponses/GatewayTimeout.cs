namespace HttpResponseExceptions
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
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.GatewayTimeout)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
