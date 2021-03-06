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
        public static HttpResponseException RedirectKeepVerb()
        {
            return new HttpResponseException(HttpStatusCode.RedirectKeepVerb);
        }

        /// <summary>
        /// HTTP status 307
        /// (the request information is located at the URI specified in the Location header)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RedirectKeepVerb(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RedirectKeepVerb)
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
        public static HttpResponseMessage RedirectKeepVerb(this HttpRequestMessage request)
        {
            return request.CreateResponse(HttpStatusCode.RedirectKeepVerb);
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
        public static HttpResponseMessage RedirectKeepVerb<T>(this HttpRequestMessage request, T content)
        {
            return request.CreateResponse<T>(HttpStatusCode.RedirectKeepVerb, content);
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
        public static HttpResponseMessage RedirectKeepVerb<T>(this HttpRequestMessage request, string reasonPhrase, T content)
        {
            var response = request.RedirectKeepVerb(content);
            response.ReasonPhrase = reasonPhrase.WithoutDiacritics();
            return response;
        }
    }
}
