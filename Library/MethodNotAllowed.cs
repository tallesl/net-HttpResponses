namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
        /// </summary>
        public static HttpResponseException MethodNotAllowed()
        {
            return new HttpResponseException(HttpStatusCode.MethodNotAllowed);
        }

        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException MethodNotAllowed(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MethodNotAllowed) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage MethodNotAllowed(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.MethodNotAllowed);
        }

        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage MethodNotAllowed<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.MethodNotAllowed, content);
        }

        /// <summary>
        /// HTTP status 405
        /// (the request method is not allowed on the requested resource)
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
        public static HttpResponseMessage MethodNotAllowed<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.MethodNotAllowed(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
