namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
        /// </summary>
        public static HttpResponseException SeeOther()
        {
            return new HttpResponseException(HttpStatusCode.SeeOther);
        }

        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException SeeOther(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.SeeOther) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage SeeOther(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.SeeOther);
        }

        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage SeeOther<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.SeeOther, content);
        }

        /// <summary>
        /// HTTP status 303
        /// (automatically redirects the client to the URI specified in the Location header as the result of a POST)
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
        public static HttpResponseMessage SeeOther<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.SeeOther(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
