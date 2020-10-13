using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{
    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#Headers">headers specification</see>, used to manipulate headers when Envoy forwards requests to, or responses from, a destination service. Header manipulation rules can be specified for a specific route destination or for all destinations. 
    /// </summary>
    public class Headers
    {

        /// <summary>
        /// Gets/sets the header manipulation rules to apply before forwarding a request to the destination service
        /// </summary>
        [JsonProperty(PropertyName = "request")]
        public HeadersOperations Request { get; set; }

        /// <summary>
        /// Gets/sets the manipulation rules to apply before returning a response to the caller
        /// </summary>
        [JsonProperty(PropertyName = "response")]
        public HeadersOperations Response { get; set; }

    }

}
