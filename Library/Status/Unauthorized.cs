namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
        /// </summary>
        public static HttpResponseException Unauthorized()
        {
            return new HttpResponseException(HttpStatusCode.Unauthorized);
        }

        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Unauthorized(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Unauthorized)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }

        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Unauthorized(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Unauthorized);
        }

        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Unauthorized<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Unauthorized, content);
        }

        /// <summary>
        /// HTTP status 401
        /// (the requested resource requires authentication)
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
        public static HttpResponseMessage Unauthorized<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Unauthorized(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
