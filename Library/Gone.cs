namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
        /// </summary>
        public static HttpResponseException Gone()
        {
            return new HttpResponseException(HttpStatusCode.Gone);
        }

        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Gone(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.Gone) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Gone(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Gone);
        }

        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Gone<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Gone, content);
        }

        /// <summary>
        /// HTTP status 410
        /// (the requested resource is no longer available)
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
        public static HttpResponseMessage Gone<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Gone(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
