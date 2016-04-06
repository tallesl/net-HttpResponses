namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 200
        /// (the request succeeded and the requested information is in the response)
        /// </summary>
        public static HttpResponseException OK()
        {
            return new HttpResponseException(HttpStatusCode.OK);
        }

        /// <summary>
        /// HTTP status 200
        /// (the request succeeded and the requested information is in the response)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException OK(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.OK) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 200
        /// (the request succeeded and the requested information is in the response)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage OK(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.OK);
        }

        /// <summary>
        /// HTTP status 200
        /// (the request succeeded and the requested information is in the response)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage OK<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.OK, content);
        }

        /// <summary>
        /// HTTP status 200
        /// (the request succeeded and the requested information is in the response)
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
        public static HttpResponseMessage OK<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.OK(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
