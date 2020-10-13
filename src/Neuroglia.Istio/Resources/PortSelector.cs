using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#PortSelector">port selector spec</see>, which specifies the number of a port to be used for matching or selection for final routing.
    /// </summary>
    public class PortSelector
    {

        /// <summary>
        /// Initializes a new <see cref="PortSelector"/>
        /// </summary>
        public PortSelector()
        {

        }

        /// <summary>
        /// Initializes a new <see cref="PortSelector"/>
        /// </summary>
        /// <param name="number">The port number</param>
        public PortSelector(int number)
        {
            this.Number = number;
        }

        /// <summary>
        /// Gets/sets the port number
        /// </summary>
        [JsonProperty(PropertyName = "number")]
        public int Number { get; set; }

    }

}
