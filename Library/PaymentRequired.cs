namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
        /// </summary>
        public static HttpResponseException PaymentRequired()
        {
            return new HttpResponseException(HttpStatusCode.PaymentRequired);
        }

        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException PaymentRequired(string reasonPhrase)
        {
            return new HttpResponseException(new HttpResponseMessage(HttpStatusCode.PaymentRequired) { ReasonPhrase = reasonPhrase });
        }

        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage PaymentRequired(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.PaymentRequired);
        }

        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage PaymentRequired<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.PaymentRequired, content);
        }

        /// <summary>
        /// HTTP status 402
        /// (reserved for future use)
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
        public static HttpResponseMessage PaymentRequired<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.PaymentRequired(content);
            response.ReasonPhrase = reasonPhrase;
            return response;
        }
    }
}
