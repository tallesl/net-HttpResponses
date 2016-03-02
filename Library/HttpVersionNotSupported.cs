namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        public static HttpResponseException HttpVersionNotSupported()
        {
            return new HttpResponseException(HttpStatusCode.HttpVersionNotSupported);
        }

        /// <summary>
        /// HTTP status 505
        /// (the requested HTTP version is not supported by the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException HttpVersionNotSupported(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.HttpVersionNotSupported)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
