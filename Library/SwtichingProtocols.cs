namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 101
        /// (the protocol version or protocol is being changed)
        /// </summary>
        public static HttpResponseException SwitchingProtocols()
        {
            return new HttpResponseException(HttpStatusCode.SwitchingProtocols);
        }

        /// <summary>
        /// HTTP status 101
        /// (the protocol version or protocol is being changed)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException SwitchingProtocols(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.SwitchingProtocols)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
