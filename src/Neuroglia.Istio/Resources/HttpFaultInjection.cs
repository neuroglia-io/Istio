using Newtonsoft.Json;
using System;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPFaultInjection">HTTPFaultInjection specification</see>, which can be used to specify one or more faults to inject while forwarding HTTP requests to the destination specified in a route. 
    /// Fault specification is part of a VirtualService rule. Faults include aborting the Http request from downstream service, and/or delaying proxying of requests. A fault rule MUST HAVE delay or abort or both.
    /// </summary>
    public class HttpFaultInjection
    {

        /// <summary>
        /// Gets/sets the 
        /// </summary>
        [JsonProperty(PropertyName = "delay")]
        public Delay Delay { get; set; }

        /// <summary>
        /// Gets/sets the 
        /// </summary>
        [JsonProperty(PropertyName = "abort")]
        public Abort Abort { get; set; }

        /// <summary>
        /// Validates the specification
        /// </summary>
        public virtual void Validate()
        {
            if (this.Delay == null && this.Abort == null)
                throw new Exception($"The {Delay} property and/or the {Abort} property must be set");
            this.Delay?.Validate();
        }

    }

}
