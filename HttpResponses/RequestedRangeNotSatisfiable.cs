namespace HttpResponseExceptions
{
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;

    public static partial class HttpResponses
    {
        /// <summary>
        /// HTTP status 416
        /// (the range of data requested from the resource cannot be returned, either because the beginning of the range is before the beginning of the resource, or the end of the range is after the end of the resource)
        /// </summary>
        public static HttpResponseException RequestedRangeNotSatisfiable()
        {
            return new HttpResponseException(HttpStatusCode.RequestedRangeNotSatisfiable);
        }

        /// <summary>
        /// HTTP status 416
        /// (the range of data requested from the resource cannot be returned, either because the beginning of the range is before the beginning of the resource, or the end of the range is after the end of the resource)
        /// </summary>
        /// <param name="reasonPhrase">
        /// The reason phrase which typically is sent by servers together with the status code
        /// </param>
        public static HttpResponseException RequestedRangeNotSatisfiable(string reasonPhrase)
        {
            return new HttpResponseException(
                new HttpResponseMessage(HttpStatusCode.RequestedRangeNotSatisfiable)
                {
                    ReasonPhrase = reasonPhrase
                }
            );
        }
    }
}
