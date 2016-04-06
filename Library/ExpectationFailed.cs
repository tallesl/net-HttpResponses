namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
        /// </summary>
        public static HttpResponseException ExpectationFailed()
        {
            return new HttpResponseException(HttpStatusCode.ExpectationFailed);
        }

        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException ExpectationFailed(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.ExpectationFailed) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage ExpectationFailed(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.ExpectationFailed);
        }

        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage ExpectationFailed<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.ExpectationFailed, content);
        }

        /// <summary>
        /// HTTP status 417
        /// (an expectation given in an Expect header could not be met by the server)
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
        public static HttpResponseMessage ExpectationFailed<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.ExpectationFailed(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
