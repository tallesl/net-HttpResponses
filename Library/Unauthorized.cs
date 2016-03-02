namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
        /// </summary>
        public static HttpResponseException Unauthorized()
        {
            return new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Unauthorized(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
