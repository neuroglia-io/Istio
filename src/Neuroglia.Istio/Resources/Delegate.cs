using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#Delegate">delegate specification</see>, which describes the delegate VirtualService.
    /// </summary>
    public class Delegate
    {

        /// <summary>
        /// Gets/sets the name of the delegate VirtualService.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the namespace where the delegate VirtualService resides. By default, it is same to the root’s.
        /// </summary>
        [JsonProperty(PropertyName = "namespace")]
        public string NamespaceProperty { get; set; }

    }

}
