namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 409
        /// (the request could not be carried out because of a conflict on the server)
        /// </summary>
        public static HttpResponseException Conflict()
        {
            return new HttpResponseException(HttpStatusCode.Conflict);
        }

        /// <summary>
        /// HTTP status 409
        /// (the request could not be carried out because of a conflict on the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Conflict(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Conflict)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
