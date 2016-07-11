namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
        /// </summary>
        public static HttpResponseException NotModified()
        {
            return new HttpResponseException(HttpStatusCode.NotModified);
        }

        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NotModified(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NotModified)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }

        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotModified(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.NotModified);
        }

        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NotModified<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.NotModified, content);
        }

        /// <summary>
        /// HTTP status 304
        /// (the client's cached copy is up to date)
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
        public static HttpResponseMessage NotModified<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.NotModified(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
