namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 502
        /// (an intermediate proxy server received a bad response from another proxy or the origin server)
        /// </summary>
        public static HttpResponseException BadGateway()
        {
            return new HttpResponseException(HttpStatusCode.BadGateway);
        }

        /// <summary>
        /// HTTP status 502
        /// (an intermediate proxy server received a bad response from another proxy or the origin server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException BadGateway(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.BadGateway)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
