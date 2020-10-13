using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{
    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#HTTPFaultInjection-Abort">abort specification</see>, which is used to prematurely abort a request with a pre-specified error code. 
    /// </summary>
    public class Abort
    {

        /// <summary>
        /// Gets/sets the HTTP status code to use to abort the Http request
        /// </summary>
        [JsonProperty(PropertyName = "httpStatus")]
        public int HttpStatus { get; set; }

        /// <summary>
        /// Gets/sets the percentage of requests to be aborted with the error code provided
        /// </summary>
        [JsonProperty(PropertyName = "percentage")]
        public Percent Percentage { get; set; }

    }

}
