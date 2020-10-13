using Neuroglia.Istio.Resources;

namespace Neuroglia.Istio
{

    /// <summary>
    /// Exposes constants about Istio defaults
    /// </summary>
    public static class IstioDefaults
    {

        /// <summary>
        /// Exposes constants about Istio default API versions
        /// </summary>
        public static class ApiVersions
        {

            /// <summary>
            /// Gets the 'networking.istio.io/v1alpha3' API version
            /// </summary>
            public const string V1Alpha3 = "networking.istio.io/v1alpha3";

        }

        /// <summary>
        /// Exposes constants about Istio default CRDs
        /// </summary>
        public static class Resources
        {

            /// <summary>
            /// Exposes constants about Istio default CRD kinds
            /// </summary>
            public static class Kinds
            {

                /// <summary>
                /// Gets the kind of the 'VirtualService' object
                /// </summary>
                public const string VirtualService = "VirtualService";

            }

            /// <summary>
            /// Gets the <see cref="Istio.Resources.VirtualService"/> CRD
            /// </summary>
            public static VirtualServiceDefinition VirtualService = new VirtualServiceDefinition();

        }

    }

}
