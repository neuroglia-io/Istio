using Newtonsoft.Json;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/#Percent">percent</see> specification, which specifies a percentage in the range of [0.0, 100.0].
    /// </summary>
    public class Percent
    {

        /// <summary>
        /// Initializes a new <see cref="Percent"/>
        /// </summary>
        public Percent()
        {

        }

        /// <summary>
        /// Initializes a new <see cref="Percent"/>
        /// </summary>
        /// <param name="value">The percentage's value</param>
        public Percent(double value)
        {
            this.Value = value;
        }

        /// <summary>
        /// Gets/sets the percentage's value
        /// </summary>
        [JsonProperty(PropertyName = "value")]
        public double Value { get; set; }

    }

}
