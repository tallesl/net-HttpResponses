namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
        /// </summary>
        public static HttpResponseException RequestTimeout()
        {
            return new HttpResponseException(HttpStatusCode.RequestTimeout);
        }

        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestTimeout(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RequestTimeout)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
