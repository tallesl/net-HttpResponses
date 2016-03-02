namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
        /// </summary>
        public static HttpResponseException NonAuthoritativeInformation()
        {
            return new HttpResponseException(HttpStatusCode.NonAuthoritativeInformation);
        }

        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NonAuthoritativeInformation(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NonAuthoritativeInformation)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
