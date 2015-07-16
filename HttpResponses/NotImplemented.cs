namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
        /// </summary>
        public static HttpResponseException NotImplemented()
        {
            return new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotImplemented(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NotImplemented)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
