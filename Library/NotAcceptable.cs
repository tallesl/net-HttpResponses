namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
        /// </summary>
        public static HttpResponseException NotAcceptable()
        {
            return new HttpResponseException(HttpStatusCode.NotAcceptable);
        }

        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotAcceptable(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotAcceptable) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotAcceptable(this HttpRequestMessage request)
        {
            return request.NotAcceptable(HttpStatusCode.NotAcceptable);
        }

        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotAcceptable<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.NotAcceptable, content);
        }

        /// <summary>
        /// HTTP status 406
        /// (the client has indicated with Accept headers that it will not accept any of the available representations of the resource)
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
        public static HttpResponseMessage NotAcceptable<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.NotAcceptable(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
