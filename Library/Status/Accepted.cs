namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    /// <summary>
    /// Less boilerplate on throwing HttpResponseExceptions.
    /// </summary>
    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
        /// </summary>
        public static HttpResponseException Accepted()
        {
            return new HttpResponseException(HttpStatusCode.Accepted);
        }

        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Accepted(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Accepted)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Accepted(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Accepted);
        }

        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Accepted<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Accepted, content);
        }

        /// <summary>
        /// HTTP status 202
        /// (the request has been accepted for further processing)
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
        public static HttpResponseMessage Accepted<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Accepted(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
