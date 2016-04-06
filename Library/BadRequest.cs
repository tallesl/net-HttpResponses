namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
        /// </summary>
        public static HttpResponseException BadRequest()
        {
            return new HttpResponseException(HttpStatusCode.BadRequest);
        }

        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException BadRequest(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.BadRequest) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage BadRequest(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.BadRequest);
        }

        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage BadRequest<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.BadRequest, content);
        }

        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
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
        public static HttpResponseMessage BadRequest<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.BadRequest(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
