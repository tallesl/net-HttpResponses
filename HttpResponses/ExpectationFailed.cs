namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
        /// </summary>
        public static HttpResponseException ExpectationFailed()
        {
            return new HttpResponseException(HttpStatusCode.ExpectationFailed);
        }

        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException ExpectationFailed(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.ExpectationFailed)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
