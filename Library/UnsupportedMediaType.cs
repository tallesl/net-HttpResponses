namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
        /// </summary>
        public static HttpResponseException UnsupportedMediaType()
        {
            return new HttpResponseException(HttpStatusCode.UnsupportedMediaType);
        }

        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException UnsupportedMediaType(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.UnsupportedMediaType) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage UnsupportedMediaType(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.UnsupportedMediaType);
        }

        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage UnsupportedMediaType<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.UnsupportedMediaType, content);
        }

        /// <summary>
        /// HTTP status 415
        /// (the request is an unsupported type)
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
        public static HttpResponseMessage UnsupportedMediaType<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.UnsupportedMediaType(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
