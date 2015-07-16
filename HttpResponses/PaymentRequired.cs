namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
        /// </summary>
        public static HttpResponseException PaymentRequired()
        {
            return new HttpResponseException(HttpStatusCode.PaymentRequired);
        }

        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException PaymentRequired(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.PaymentRequired)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
