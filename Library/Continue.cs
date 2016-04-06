namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
        /// </summary>
        public static HttpResponseException Continue()
        {
            return new HttpResponseException(HttpStatusCode.Continue);
        }

        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Continue(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Continue) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Continue(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Continue);
        }

        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Continue<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Continue, content);
        }

        /// <summary>
        /// HTTP status 100
        /// (the client can continue with its request)
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
        public static HttpResponseMessage Continue<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Continue(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
