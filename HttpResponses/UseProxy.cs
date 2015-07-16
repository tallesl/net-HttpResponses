namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 305
        /// (the request should use the proxy server at the URI specified in the Location header)
        /// </summary>
        public static HttpResponseException UseProxy()
        {
            return new HttpResponseException(HttpStatusCode.UseProxy);
        }

        /// <summary>
        /// HTTP status 305
        /// (the request should use the proxy server at the URI specified in the Location header)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException UseProxy(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.UseProxy)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
