namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
        /// </summary>
        public static HttpResponseException LengthRequired()
        {
            return new HttpResponseException(HttpStatusCode.LengthRequired);
        }

        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException LengthRequired(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.LengthRequired) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage LengthRequired(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.LengthRequired);
        }

        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage LengthRequired<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.LengthRequired, content);
        }

        /// <summary>
        /// HTTP status 411
        /// (the required Content-length header is missing)
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
        public static HttpResponseMessage LengthRequired<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.LengthRequired(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
