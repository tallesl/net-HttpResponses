namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
        /// </summary>
        public static HttpResponseException RequestUriTooLong()
        {
            return new HttpResponseException(HttpStatusCode.RequestUriTooLong);
        }

        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestUriTooLong(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RequestUriTooLong)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
