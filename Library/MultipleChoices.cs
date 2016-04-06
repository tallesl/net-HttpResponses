namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        public static HttpResponseException MultipleChoices()
        {
            return new HttpResponseException(HttpStatusCode.MultipleChoices);
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException MultipleChoices(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.MultipleChoices) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage MultipleChoices(this HttpRequestMessage request)
        {
            return request.MultipleChoices(HttpStatusCode.MultipleChoices);
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage MultipleChoices<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.MultipleChoices, content);
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
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
        public static HttpResponseMessage MultipleChoices<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.MultipleChoices(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
