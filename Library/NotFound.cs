namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
        /// </summary>
        public static HttpResponseException NotFound()
        {
            return new HttpResponseException(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotFound(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NotFound)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
