namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
        /// </summary>
        public static HttpResponseException NotModified()
        {
            return new HttpResponseException(HttpStatusCode.NotModified);
        }

        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotModified(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NotModified)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
