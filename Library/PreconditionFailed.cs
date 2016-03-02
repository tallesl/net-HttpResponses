namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
        /// </summary>
        public static HttpResponseException PreconditionFailed()
        {
            return new HttpResponseException(HttpStatusCode.PreconditionFailed);
        }

        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException PreconditionFailed(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.PreconditionFailed)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
