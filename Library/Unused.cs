namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
        /// </summary>
        public static HttpResponseException Unused()
        {
            return new HttpResponseException(HttpStatusCode.Unused);
        }

        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Unused(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Unused)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
