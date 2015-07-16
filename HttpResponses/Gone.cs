namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
        /// </summary>
        public static HttpResponseException Gone()
        {
            return new HttpResponseException(HttpStatusCode.Gone);
        }

        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Gone(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Gone)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
