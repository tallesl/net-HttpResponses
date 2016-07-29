namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
        /// </summary>
        public static HttpResponseException RequestTimeout()
        {
            return new HttpResponseException(HttpStatusCode.RequestTimeout);
        }

        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestTimeout(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RequestTimeout)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage RequestTimeout(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.RequestTimeout);
        }

        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage RequestTimeout<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.RequestTimeout, content);
        }

        /// <summary>
        /// HTTP status 408
        /// (the client did not send a request within the time the server was expecting the request)
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
        public static HttpResponseMessage RequestTimeout<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.RequestTimeout(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
