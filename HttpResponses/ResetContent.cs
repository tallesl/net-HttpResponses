namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 205
        /// (the client should reset (not reload) the current resource)
        /// </summary>
        public static HttpResponseException ResetContent()
        {
            return new HttpResponseException(HttpStatusCode.ResetContent);
        }

        /// <summary>
        /// HTTP status 205
        /// (the client should reset (not reload) the current resource)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException ResetContent(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.ResetContent)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
