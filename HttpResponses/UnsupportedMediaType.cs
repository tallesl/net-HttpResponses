namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
        /// </summary>
        public static HttpResponseException UnsupportedMediaType()
        {
            return new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
        }

        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException UnsupportedMediaType(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.UnsupportedMediaType)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
