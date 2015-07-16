namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
        /// </summary>
        public static HttpResponseException NoContent()
        {
            return new HttpResponseException(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NoContent(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NoContent)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
