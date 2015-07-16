namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 200
        /// (the request succeeded and the requested information is in the response)
        /// </summary>
        public static HttpResponseException OK()
        {
            return new HttpResponseException(HttpStatusCode.OK);
        }

        /// <summary>
        /// HTTP status 200 (the request succeeded and the requested information is in the response).
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException OK(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.OK)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
