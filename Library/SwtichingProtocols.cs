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
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.SwitchingProtocols) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 101
        /// (the protocol version or protocol is being changed)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage SwitchingProtocols(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.SwitchingProtocols);
        }

        /// <summary>
        /// HTTP status 101
        /// (the protocol version or protocol is being changed)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage SwitchingProtocols<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.SwitchingProtocols, content);
        }

        /// <summary>
        /// HTTP status 101
        /// (the protocol version or protocol is being changed)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage SwitchingProtocols<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.SwitchingProtocols(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
