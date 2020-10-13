using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPRewrite">http rewrite specification</see>, which can be used to rewrite specific parts of a HTTP request before forwarding the request to the destination. Rewrite primitive can be used only with HTTPRouteDestination.
    /// </summary>
    public class HttpRewrite
    {

        /// <summary>
        /// Gets/sets the value used to rewrite the path (or the prefix) portion of the URI. If the original URI was matched based on prefix, the value provided in this field will replace the corresponding matched prefix.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public string Uri { get; set; }

        /// <summary>
        /// Gets/sets the value used to rewrite the Authority/Host header.
        /// </summary>
        [JsonProperty(PropertyName = "authority")]
        public string Authority { get; set; }

    }

}
