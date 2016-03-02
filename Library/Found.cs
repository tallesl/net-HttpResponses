namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 302
        /// (the requested information is located at the URI specified in the Location header)
        /// </summary>
        public static HttpResponseException Found()
        {
            return new HttpResponseException(HttpStatusCode.Found);
        }

        /// <summary>
        /// HTTP status 302
        /// (the requested information is located at the URI specified in the Location header)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Found(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Found)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
