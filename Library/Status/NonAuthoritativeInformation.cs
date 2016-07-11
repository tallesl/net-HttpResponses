namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
        /// </summary>
        public static HttpResponseException NonAuthoritativeInformation()
        {
            return new HttpResponseException(HttpStatusCode.NonAuthoritativeInformation);
        }

        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException NonAuthoritativeInformation(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.NonAuthoritativeInformation)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NonAuthoritativeInformation(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.NonAuthoritativeInformation);
        }

        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage NonAuthoritativeInformation<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.NonAuthoritativeInformation, content);
        }

        /// <summary>
        /// HTTP status 203
        /// (the returned metainformation is from a cached copy instead of the origin server and therefore may be incorrect)
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
        public static HttpResponseMessage NonAuthoritativeInformation<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.NonAuthoritativeInformation(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
