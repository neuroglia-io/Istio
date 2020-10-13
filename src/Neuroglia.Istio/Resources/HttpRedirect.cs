using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPRedirect">http redirect specification</see>, which is used to send a 301 redirect response to the caller, where the Authority/Host and the URI in the response can be swapped with the specified values.
    /// </summary>
    public class HttpRedirect
    {

        /// <summary>
        /// Initializes a new <see cref="HttpRedirect"/>
        /// </summary>
        public HttpRedirect()
        {
            this.RedirectCode = 301;
        }

        /// <summary>
        /// Gets/sets the value used to overwrite the Path portion of the URL. Note that the entire path will be replaced, irrespective of the request URI being matched as an exact path or prefix.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets/sets the value used to overwrite the Authority/Host portion of the URL.
        /// </summary>
        [JsonProperty(PropertyName = "authority")]
        public string Authority { get; set; }

        /// <summary>
        /// Gets/sets the http status code to use in the redirect response. The default response code is MOVED_PERMANENTLY (301).
        /// </summary>
        [JsonProperty(PropertyName = "redirectCode")]
        public uint RedirectCode { get; set; }

    }

}
