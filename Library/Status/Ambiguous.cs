﻿namespace HttpResponsesLibrary
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
        public static HttpResponseException Ambiguous()
        {
            return new HttpResponseException(HttpStatusCode.Ambiguous);
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException Ambiguous(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.Ambiguous)
                {
                    ReasonPhrase = reasonPhrase.WithoutDiacritics()
                }
            );
        }

        /// <summary>
        /// HTTP status 300
        /// (the requested information has multiple representations)
        /// </summary>
        /// <param name="request">The HTTP request message which led to this response message</param>
        /// <returns>
        /// An initialized System.Net.Http.HttpResponseMessage wired up to the associated System.Net.Http.HttpRequestMessage
        /// </returns>
        public static HttpResponseMessage Ambiguous(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.Ambiguous);
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
        public static HttpResponseMessage Ambiguous<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.Ambiguous, content);
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
        public static HttpResponseMessage Ambiguous<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.Ambiguous(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
