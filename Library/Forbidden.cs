namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
        /// </summary>
        public static HttpResponseException Forbidden()
        {
            return new HttpResponseException(HttpStatusCode.Forbidden);
        }

        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Forbidden(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Forbidden) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Forbidden(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Forbidden);
        }

        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Forbidden<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Forbidden, content);
        }

        /// <summary>
        /// HTTP status 403
        /// (the server refuses to fulfill the request)
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
        public static HttpResponseMessage Forbidden<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Forbidden(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
