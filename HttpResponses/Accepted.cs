namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
        /// </summary>
        public static HttpResponseException Accepted()
        {
            return new HttpResponseException(HttpStatusCode.Accepted);
        }

        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Accepted(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Accepted)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
