namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
        /// </summary>
        public static HttpResponseException RequestEntityTooLarge()
        {
            return new HttpResponseException(HttpStatusCode.RequestEntityTooLarge);
        }

        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestEntityTooLarge(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.RequestEntityTooLarge) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage RequestEntityTooLarge(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.RequestEntityTooLarge);
        }

        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage RequestEntityTooLarge<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.RequestEntityTooLarge, content);
        }

        /// <summary>
        /// HTTP status 413
        /// (the request is too large for the server to process)
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
        public static HttpResponseMessage RequestEntityTooLarge<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.RequestEntityTooLarge(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
