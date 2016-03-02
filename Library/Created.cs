namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 201
        /// (the request resulted in a new resource created before the response was sent)
        /// </summary>
        public static HttpResponseException Created()
        {
            return new HttpResponseException(HttpStatusCode.Created);
        }

        /// <summary>
        /// HTTP status 201
        /// (the request resulted in a new resource created before the response was sent)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Created(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Created)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
