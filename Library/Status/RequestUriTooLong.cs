namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
        /// </summary>
        public static HttpResponseException RequestUriTooLong()
        {
            return new HttpResponseException(HttpStatusCode.RequestUriTooLong);
        }

        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestUriTooLong(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RequestUriTooLong)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage RequestUriTooLong(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.RequestUriTooLong);
        }

        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage RequestUriTooLong<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.RequestUriTooLong, content);
        }

        /// <summary>
        /// HTTP status 414
        /// (the URI is too long)
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
        public static HttpResponseMessage RequestUriTooLong<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.RequestUriTooLong(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
