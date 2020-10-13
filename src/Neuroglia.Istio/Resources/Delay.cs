using Newtonsoft.Json;
using System;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPFaultInjection-Delay">delay specification</see>, which is used to inject latency into the request forwarding path. 
    /// </summary>
    public class Delay
    {

        /// <summary>
        /// Gets/sets a fixed delay before forwarding the request. Format: 1h/1m/1s/1ms. MUST be >=1ms. 
        /// </summary>
        [JsonProperty(PropertyName = "fixedDelay")]
        public string FixedDelay { get; set; }

        /// <summary>
        /// Gets/sets the percentage of requests on which the delay will be injected.
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public Percent Percentage { get; set; }

        /// <summary>
        /// Gets/sets the percentage of requests on which the delay will be injected (0-100).
        /// </summary>
        [Obsolete("Use of integer percent value is deprecated. Use the double percentage field instead.")]
        [JsonProperty(PropertyName = "percent")]
        public int Percent { get; set; }

        /// <summary>
        /// Validates the specification
        /// </summary>
        public virtual void Validate()
        {
            if (string.IsNullOrWhiteSpace(this.FixedDelay))
                throw new NullReferenceException($"The {FixedDelay} property must be set");
        }

    }

}
