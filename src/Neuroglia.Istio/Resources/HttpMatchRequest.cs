using Newtonsoft.Json;
using System.Collections.Generic;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPMatchRequest">HttpMatchRequest specification</see>, used to specify a set of criterion to be met in order for the rule to be applied to the HTTP request.
    /// </summary>
    public class HttpMatchRequest
    {

        /// <summary>
        /// Gets/sets the name assigned to a match. The match’s name will be concatenated with the parent route’s name and will be logged in the access logs for requests matching this route.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the case-sensitive uri to match<para></para>
        /// NOTES: Note: Case-insensitive matching could be enabled via the <see cref="IgnoreUriCase"/> flag.
        /// </summary>
        [JsonProperty(PropertyName = "uri")]
        public StringMatch Uri { get; set; }

        /// <summary>
        /// Gets/sets the case-sensitive scheme to match
        /// </summary>
        [JsonProperty(PropertyName = "scheme")]
        public StringMatch Scheme { get; set; }

        /// <summary>
        /// Gets/sets the case-sensitive method to match
        /// </summary>
        [JsonProperty(PropertyName = "method")]
        public StringMatch Method { get; set; }

        /// <summary>
        /// Gets/sets the case-sensitive authority to match
        /// </summary>
        [JsonProperty(PropertyName = "authority")]
        public StringMatch Authority { get; set; }

        /// <summary>
        /// Gets/sets the headers to match. The header keys must be lowercase and use hyphen as the separator, e.g. x-request-id.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public IDictionary<string, StringMatch> Headers { get; set; }

        /// <summary>
        /// Gets/sets the ports on the host that is being addressed. Many services only expose a single port or label ports with the protocols they support, in these cases it is not required to explicitly select the port
        /// </summary>
        [JsonProperty(PropertyName = "port")]
        public int Port { get; set; }

        /// <summary>
        /// Gets/sets one or more labels that constrain the applicability of a rule to workloads with the given labels. If the VirtualService has a list of gateways specified in the top-level gateways field, it must include the reserved gateway mesh for this field to be applicable.
        /// </summary>
        [JsonProperty(PropertyName = "sourceLabels")]
        public IDictionary<string, string> SourceLabels { get; set; }

        /// <summary>
        /// Gets/sets names of gateways where the rule should be applied. Gateway names in the top-level gateways field of the VirtualService (if any) are overridden. The gateway match is independent of sourceLabels.
        /// </summary>
        [JsonProperty(PropertyName = "gateways")]
        public IList<string> Gateways { get; set; }

        /// <summary>
        /// Gets/sets query parameters to match.
        /// </summary>
        [JsonProperty(PropertyName = "queryParams")]
        public IDictionary<string, StringMatch> QueryParams { get; set; }

        /// <summary>
        /// Gets/sets a flag to specify whether the URI matching should be case-insensitive.
        /// </summary>
        [JsonProperty(PropertyName = "ignoreUriCase")]
        public bool IgnoreUriCase { get; set; }

        /// <summary>
        /// Gets/sets the headers not to match. The header keys must be lowercase and use hyphen as the separator, e.g. x-request-id.
        /// </summary>
        [JsonProperty(PropertyName = "withoutHeaders")]
        public IDictionary<string, StringMatch> WithoutHeaders { get; set; }

        /// <summary>
        /// Gets/sets the source namespace constraining the applicability of a rule to workloads in that namespace. If the VirtualService has a list of gateways specified in the top-level gateways field, it must include the reserved gateway mesh for this field to be applicable.
        /// </summary>
        [JsonProperty(PropertyName = "sourceNamespace")]
        public string SourceNamespace { get; set; }

    }

}
