﻿namespace HttpResponsesLibrary
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        public static HttpResponseException TemporaryRedirect()
        {
            return new HttpResponseException(HttpStatusCode.TemporaryRedirect);
        }

        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException TemporaryRedirect(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.TemporaryRedirect)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage TemporaryRedirect(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.TemporaryRedirect);
        }

        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        /// <typeparam name="T">The content of the HTTP response message</typeparam>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <param name="content">The content of the HTTP response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage TemporaryRedirect<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.TemporaryRedirect, content);
        }

        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
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
        public static HttpResponseMessage TemporaryRedirect<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.TemporaryRedirect(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
