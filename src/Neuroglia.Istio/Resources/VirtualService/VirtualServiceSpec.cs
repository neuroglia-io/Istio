using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the specification of a <see cref="VirtualService"/>
    /// </summary>
    public class VirtualServiceSpec
    {

        /// <summary>
        /// Gets/sets the destination hosts to which traffic is being sent. Could be a DNS name with wildcard prefix or an IP address.
        /// Depending on the platform, short-names can also be used instead of a FQDN (i.e. has no dots in the name). In such a scenario, the FQDN of the host would be derived based on the underlying platform.
        /// </summary>
        [JsonProperty(PropertyName = "hosts")]
        public IList<string> Hosts { get; set; }

        /// <summary>
        /// Gets/sets the names of gateways and sidecars that should apply these routes.
        /// </summary>
        [JsonProperty(PropertyName = "gateways")]
        public IList<string> Gateways { get; set; }

        /// <summary>
        /// Gets/sets an ordered <see cref="IList{T}"/> of route rules for HTTP traffic. 
        /// <para>HTTP routes will be applied to platform service ports named ‘http-’/‘http2-’/‘grpc-*’, gateway ports with protocol HTTP/HTTP2/GRPC/ TLS-terminated-HTTPS and service entry ports using HTTP/HTTP2/GRPC protocols. </para>
        /// <para>The first rule matching an incoming request is used.</para>
        /// </summary>
        [JsonProperty(PropertyName = "http")]
        public IList<HttpRoute> Http { get; set; }

        /// <summary>
        /// Gets/sets an <see cref="IList{T}"/> of namespaces to which this <see cref="VirtualService"/> is exported. 
        /// Exporting a <see cref="VirtualService"/> allows it to be used by sidecars and gateways defined in other namespaces. This feature provides a mechanism for service owners and mesh administrators to control the visibility of <see cref="VirtualService"/>s across namespace boundaries.
        /// </summary>
        [JsonProperty(PropertyName = "exportTo")]
        public IList<string> ExportTo { get; set; }

        /// <summary>
        /// Validates the specification
        /// </summary>
        public virtual void Validate()
        {
            if (this.Hosts == null)
                throw new Exception($"The {Hosts} property must be set, with at least one host defined");
            if(this.Http != null)
            {
                foreach(HttpRoute route in this.Http)
                {
                    route.Validate();
                }
            }
        }

    }

}
