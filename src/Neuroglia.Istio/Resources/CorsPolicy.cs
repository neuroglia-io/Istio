using Newtonsoft.Json;
using System.Collections.Generic;

namespace Neuroglia.Istio.Resources
{
    /// <summary>
    /// Rezpresents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#CorsPolicy">CORS policy specification</see>, which describes the Cross-Origin Resource Sharing (CORS) policy, for a given service. Refer to CORS for further details about cross origin resource sharing.
    /// </summary>
    public class CorsPolicy
    {

        /// <summary>
        /// Gets/sets string patterns that match allowed origins. An origin is allowed if any of the string matchers match. If a match is found, then the outgoing Access-Control-Allow-Origin would be set to the origin as provided by the client.
        /// </summary>
        [JsonProperty(PropertyName = "allowOrigins")]
        public IList<StringMatch> AllowOrigins { get; set; }

        /// <summary>
        /// Gets/sets an <see cref="IList{T}"/> of HTTP methods allowed to access the resource. The content will be serialized into the Access-Control-Allow-Methods header.
        /// </summary>
        [JsonProperty(PropertyName = "allowMethods")]
        public IList<string> AllowMethods { get; set; }

        /// <summary>
        /// Gets/sets an <see cref="IList{T}"/> of HTTP headers that can be used when requesting the resource. Serialized to Access-Control-Allow-Headers header.
        /// </summary>
        [JsonProperty(PropertyName = "allowHeaders")]
        public IList<string> AllowHeaders { get; set; }

        /// <summary>
        /// Gets/sets an <see cref="IList{T}"/> of HTTP headers that the browsers are allowed to access. Serialized into Access-Control-Expose-Headers header.
        /// </summary>
        [JsonProperty(PropertyName = "exposeHeaders")]
        public IList<string> ExposeHeaders { get; set; }

        /// <summary>
        /// Gets/sets a value which specifies how long the results of a preflight request can be cached. Translates to the Access-Control-Max-Age header.
        /// </summary>
        [JsonProperty(PropertyName = "maxAge")]
        public string MaxAge { get; set; }

        /// <summary>
        /// Gets/sets a boolean indicating whether the caller is allowed to send the actual request (not the preflight) using credentials. Translates to Access-Control-Allow-Credentials header.
        /// </summary>
        [JsonProperty(PropertyName = "allowCredentials")]
        public bool AllowCredentials { get; set; }

    }

}
