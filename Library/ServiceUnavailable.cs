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
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.ServiceUnavailable)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
