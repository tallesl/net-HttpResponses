namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
        /// </summary>
        public static HttpResponseException RequestEntityTooLarge()
        {
            return new HttpResponseException(HttpStatusCode.RequestEntityTooLarge);
        }

        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestEntityTooLarge(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RequestEntityTooLarge)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
