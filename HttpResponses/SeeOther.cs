namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
        /// </summary>
        public static HttpResponseException SeeOther()
        {
            return new HttpResponseException(HttpStatusCode.SeeOther);
        }

        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException SeeOther(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.SeeOther)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
