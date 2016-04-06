namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
        /// </summary>
        public static HttpResponseException NotImplemented()
        {
            return new HttpResponseException(HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotImplemented(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotImplemented) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotImplemented(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotImplemented<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.NotImplemented, content);
        }

        /// <summary>
        /// HTTP status 501
        /// (the server does not support the requested function)
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
        public static HttpResponseMessage NotImplemented<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.NotImplemented(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
