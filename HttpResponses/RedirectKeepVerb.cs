namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        public static HttpResponseException RedirectKeepVerb()
        {
            return new HttpResponseException(HttpStatusCode.RedirectKeepVerb);
        }

        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RedirectKeepVerb(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RedirectKeepVerb)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
