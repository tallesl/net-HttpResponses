namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
        /// </summary>
        public static HttpResponseException NoContent()
        {
            return new HttpResponseException(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NoContent(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NoContent) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NoContent(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.NoContent);
        }

        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NoContent<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.NoContent, content);
        }

        /// <summary>
        /// HTTP status 204
        /// (the request has been successfully processed and that the response is intentionally blank)
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
        public static HttpResponseMessage NoContent<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.NoContent(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
