namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
        /// </summary>
        public static HttpResponseException PartialContent()
        {
            return new HttpResponseException(HttpStatusCode.PartialContent);
        }

        /// <summary>
        /// HTTP status 206
        /// (the response is a partial response as requested by a GET request that includes a byte range)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException PartialContent(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.PartialContent)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
