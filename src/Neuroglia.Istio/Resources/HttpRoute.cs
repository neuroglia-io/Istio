using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPRoute">http route specification</see>, which is used to match conditions and actions for routing HTTP/1.1, HTTP2, and gRPC traffic.
    /// </summary>
    public class HttpRoute
    {

        /// <summary>
        /// Gets/sets the name assigned to the route for debugging purposes. The route’s name will be concatenated with the match’s name and will be logged in the access logs for requests matching this route/match.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets/sets the match conditions to be satisfied for the rule to be activated. All conditions inside a single match block have AND semantics, while the list of match blocks have OR semantics. The rule is matched if any one of the match blocks succeed.
        /// </summary>
        [JsonProperty(PropertyName = "match")]
        public IList<HttpMatchRequest> Match { get; set; }

        /// <summary>
        /// Gets/sets the HTTP rule can either redirect or forward (default) traffic. The forwarding target can be one of several versions of a service (see glossary in beginning of document). Weights associated with the service version determine the proportion of traffic it receives.
        /// </summary>
        [JsonProperty(PropertyName = "route")]
        public IList<HttpRouteDestination> Route { get; set; }

        /// <summary>
        /// Gets/sets the primitive used to send a HTTP 301 redirect to a different URI or Authority.
        /// </summary>
        [JsonProperty(PropertyName = "redirect")]
        public HttpRedirect Redirect { get; set; }

        /// <summary>
        /// Gets/sets the primitive used to specify the particular VirtualService which can be used to define delegate HTTPRoute. It can be set only when <see cref="Route"/> and <see cref="Redirect"/> are empty, and the route rules of the delegate VirtualService will be merged with that in the current one. 
        /// <para>NOTES:</para>
        /// <para>1. Only one level delegation is supported.</para>
        /// <para>2. The delegate’s HTTPMatchRequest must be a strict subset of the root’s, otherwise there is a conflict and the HTTPRoute will not take effect.</para> 
        /// </summary>
        [JsonProperty(PropertyName = "delegate")]
        public Delegate Delegate { get; set; }

        /// <summary>
        /// Gets/sets the primitive used to configure the way HTTP URIs and Authority headers are rewritten. Rewrite cannot be used with <see cref="Redirect"/> primitive. Rewrite will be performed before forwarding.
        /// </summary>
        [JsonProperty(PropertyName = "rewrite")]
        public HttpRewrite Rewrite { get; set; }

        /// <summary>
        /// Gets/sets the timeout for HTTP requests. Disabled by default
        /// </summary>
        [JsonProperty(PropertyName = "timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// Gets/sets the retry policy for HTTP requests.
        /// </summary>
        [JsonProperty(PropertyName = "retries")]
        public HttpRetry Retries { get; set; }

        /// <summary>
        /// Gets/sets the policy to apply on HTTP traffic at the client side. Note that timeouts or retries will not be enabled when faults are enabled on the client side.
        /// </summary>
        [JsonProperty(PropertyName = "fault")]
        public HttpFaultInjection Fault { get; set; }

        /// <summary>
        /// Gets/sets the primitive used to mirror HTTP traffic to a another destination in addition to forwarding the requests to the intended destination. 
        /// Mirrored traffic is on a best effort basis where the sidecar/gateway will not wait for the mirrored cluster to respond before returning the response from the original destination. Statistics will be generated for the mirrored destination.
        /// </summary>
        [JsonProperty(PropertyName = "mirror")]
        public Destination Mirror { get; set; }

        /// <summary>
        /// Gets/sets the percentage of the traffic to be mirrored by the mirror field. If this field is absent, all the traffic (100%) will be mirrored. Max value is 100.
        /// </summary>
        [JsonProperty(PropertyName = "mirrorPercentage")]
        public Percent MirrorPercentage { get; set; }

        /// <summary>
        /// Gets/sets the Cross-Origin Resource Sharing policy (CORS). Refer to CORS for further details about cross origin resource sharing.
        /// </summary>
        [JsonProperty(PropertyName = "corsPolicy")]
        public CorsPolicy CorsPolicy { get; set; }

        /// <summary>
        /// Gets/sets header manipulation rules.
        /// </summary>
        [JsonProperty(PropertyName = "headers")]
        public Headers Headers { get; set; }

        /// <summary>
        /// Gets/sets the percentage of the traffic to be mirrored by the mirror field.
        /// </summary>
        [Obsolete("Use of integer 'mirror_percent' value is deprecated. Use the double 'mirror_percentage' field instead")]
        [JsonProperty(PropertyName = "mirrorPercent")]
        public uint MirrorPercent { get; set; }

        /// <summary>
        /// Validates the specification
        /// </summary>
        public virtual void Validate()
        {
            if ((this.Route == null || !this.Route.Any())
                && this.Redirect == null)
                throw new Exception($"The {Route} and/or {Redirect} property must be set");
            if(this.Route != null)
            {
                foreach (HttpRouteDestination route in this.Route)
                {
                    route.Validate();
                }
            }
            this.Retries?.Validate();
            this.Fault?.Validate();
            this.Mirror?.Validate();
        }

    }

}
