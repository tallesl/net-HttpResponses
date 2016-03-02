namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        public static HttpResponseException MultipleChoices()
        {
            return new HttpResponseException(HttpStatusCode.MultipleChoices);
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException MultipleChoices(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.MultipleChoices)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
