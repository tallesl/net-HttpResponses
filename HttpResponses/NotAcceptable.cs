namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
        /// </summary>
        public static HttpResponseException NotAcceptable()
        {
            return new HttpResponseException(HttpStatusCode.NotAcceptable);
        }

        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotAcceptable(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NotAcceptable)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
