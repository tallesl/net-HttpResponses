namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
        /// </summary>
        public static HttpResponseException LengthRequired()
        {
            return new HttpResponseException(HttpStatusCode.LengthRequired);
        }

        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException LengthRequired(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.LengthRequired)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
