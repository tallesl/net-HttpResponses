﻿namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
        /// </summary>
        public static HttpResponseException BadRequest()
        {
            return new HttpResponseException(HttpStatusCode.BadRequest);
        }

        /// <summary>
        /// HTTP status 400
        /// (the request could not be understood by the server)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException BadRequest(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.BadRequest)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
