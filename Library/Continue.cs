namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
        /// </summary>
        public static HttpResponseException Continue()
        {
            return new HttpResponseException(HttpStatusCode.Continue);
        }

        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Continue(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Continue)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
