using Neuroglia.K8s;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the definition of the <see cref="VirtualService"/> custom resource
    /// </summary>
    public class VirtualServiceDefinition
        : CustomResourceDefinition
    {

        /// <summary>
        /// Gets the <see cref="VirtualServiceDefinition"/>'s kind
        /// </summary>
        public const string KIND = IstioDefaults.Resources.Kinds.VirtualService;
        /// <summary>
        /// Gets the <see cref="VirtualServiceDefinition"/>'s plural
        /// </summary>
        public const string PLURAL = "virtualservices";

        /// <summary>
        /// Initializes a new <see cref="VirtualServiceDefinition"/>
        /// </summary>
        public VirtualServiceDefinition()
            : base(IstioDefaults.ApiVersions.V1Alpha3, KIND, PLURAL)
        {

        }

    }

}
