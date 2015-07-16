namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 500
        /// (a generic error has occurred on the server)
        /// </summary>
        public static HttpResponseException InternalServerError()
        {
            return new HttpResponseException(HttpStatusCode.InternalServerError);
        }

        /// <summary>
        /// HTTP status 500
        /// (a generic error has occurred on the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException InternalServerError(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.InternalServerError)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
