namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
        /// </summary>
        public static HttpResponseException NotFound()
        {
            return new HttpResponseException(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotFound(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotFound(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.NotFound);
        }

        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotFound<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.NotFound, content);
        }

        /// <summary>
        /// HTTP status 404
        /// (the requested resource does not exist on the server)
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
        public static HttpResponseMessage NotFound<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.NotFound(HttpStatusCode.NotFound);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
