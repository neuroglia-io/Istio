using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#StringMatch">string match specification</see>, which describes how to match a given string in HTTP headers. Match is case-sensitive.
    /// </summary>
    public class StringMatch
    {

        /// <summary>
        /// Gets/sets the exact string match
        /// </summary>
        [JsonProperty(PropertyName = "exact")]
        public string Exact { get; set; }

        /// <summary>
        /// Gets/sets the prefix-based match
        /// </summary>
        [JsonProperty(PropertyName = "prefix")]
        public string Prefix { get; set; }

        /// <summary>
        /// Gets/sets the RE2 style regex-based match (<see href="https://github.com/google/re2/wiki/Syntax"/>)
        /// </summary>
        [JsonProperty(PropertyName = "regex")]
        public string Regex { get; set; }

    }

}
