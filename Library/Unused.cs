namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
        /// </summary>
        public static HttpResponseException Unused()
        {
            return new HttpResponseException(HttpStatusCode.Unused);
        }

        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Unused(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Unused) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Unused(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Unused);
        }

        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Unused<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Unused, content);
        }

        /// <summary>
        /// HTTP status 306
        /// (a proposed extension to the HTTP/1.1 specification that is not fully specified)
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
        public static HttpResponseMessage Unused<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Unused(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
