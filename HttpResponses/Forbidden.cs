namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
        /// </summary>
        public static HttpResponseException Forbidden()
        {
            return new HttpResponseException(HttpStatusCode.Forbidden);
        }

        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Forbidden(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Forbidden)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
