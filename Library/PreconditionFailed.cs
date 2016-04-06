namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
        /// </summary>
        public static HttpResponseException PreconditionFailed()
        {
            return new HttpResponseException(HttpStatusCode.PreconditionFailed);
        }

        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException PreconditionFailed(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.PreconditionFailed) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage PreconditionFailed(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.PreconditionFailed);
        }

        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage PreconditionFailed<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.PreconditionFailed, content);
        }

        /// <summary>
        /// HTTP status 412
        /// (a condition set for this request failed, and the request cannot be carried out)
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
        public static HttpResponseMessage PreconditionFailed<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.PreconditionFailed(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
