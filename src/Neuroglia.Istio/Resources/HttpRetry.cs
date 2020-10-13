using Newtonsoft.Json;
using System;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPRetry">http retry specification</see>, used when a HTTP request fails.
    /// </summary>
    public class HttpRetry
    {

        /// <summary>
        /// Initializes a new <see cref="HttpRetry"/>
        /// </summary>
        public HttpRetry()
        {

        }

        /// <summary>
        /// Initializes a new <see cref="HttpRetry"/>
        /// </summary>
        /// <param name="attempts">The number of retries for a given request.</param>
        /// <param name="perRetryTimeout">The timeout per retry attempt for a given request. </param>
        /// <param name="retryOn">The conditions under which retry takes place.</param>
        /// <param name="retryRemoveLocalities">The flag to specify whether the retries should retry to other localities</param>
        public HttpRetry(int attempts, string perRetryTimeout, string retryOn, bool retryRemoveLocalities)
        {
            this.Attempts = attempts;
            this.PerTryTimeout = perRetryTimeout;
            this.RetryOn = retryOn;
            this.RetryRemoteLocalities = retryRemoveLocalities;
        }

        /// <summary>
        /// Initializes a new <see cref="HttpRetry"/>
        /// </summary>
        /// <param name="attempts">The number of retries for a given request.</param>
        /// <param name="perRetryTimeout">The timeout per retry attempt for a given request. </param>
        /// <param name="retryOn">The conditions under which retry takes place.</param>
        public HttpRetry(int attempts, string perRetryTimeout, string retryOn)
            : this(attempts, perRetryTimeout, retryOn, false)
        {

        }

        /// <summary>
        /// Initializes a new <see cref="HttpRetry"/>
        /// </summary>
        /// <param name="attempts">The number of retries for a given request.</param>
        /// <param name="perRetryTimeout">The timeout per retry attempt for a given request. </param>
        public HttpRetry(int attempts, string perRetryTimeout)
             : this(attempts, perRetryTimeout, null, false)
        {

        }

        /// <summary>
        /// Initializes a new <see cref="HttpRetry"/>
        /// </summary>
        /// <param name="attempts">The number of retries for a given request.</param>
        public HttpRetry(int attempts)
             : this(attempts, null, null, false)
        {

        }

        /// <summary>
        /// Gets/sets the number of retries for a given request. The interval between retries will be determined automatically (25ms+). Actual number of retries attempted depends on the request timeout of the HTTP route.
        /// </summary>
        [JsonProperty(PropertyName = "attempts")]
        public int? Attempts { get; set; }

        /// <summary>
        /// Gets/sets the imeout per retry attempt for a given request. format: 1h/1m/1s/1ms. MUST BE >=1ms.
        /// </summary>
        [JsonProperty(PropertyName = "perTryTimeout")]
        public string PerTryTimeout { get; set; }

        /// <summary>
        /// Gets/sets the conditions under which retry takes place. One or more policies can be specified using a ‘,’ delimited list. See the retry policies and gRPC retry policies for more details.
        /// </summary>
        [JsonProperty(PropertyName = "retryOn")]
        public string RetryOn { get; set; }

        /// <summary>
        /// Gets/sets the flag to specify whether the retries should retry to other localities. See the retry plugin configuration for more details.
        /// </summary>
        [JsonProperty(PropertyName = "retryRemoteLocalities")]
        public bool RetryRemoteLocalities { get; set; }

        /// <summary>
        /// Validates the specification
        /// </summary>
        public virtual void Validate()
        {
            if (!this.Attempts.HasValue)
                throw new Exception($"The {Attempts} property must be set");
        }

    }

}
