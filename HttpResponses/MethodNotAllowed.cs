namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
        /// </summary>
        public static HttpResponseException MethodNotAllowed()
        {
            return new HttpResponseException(HttpStatusCode.MethodNotAllowed);
        }

        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException MethodNotAllowed(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.MethodNotAllowed)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
