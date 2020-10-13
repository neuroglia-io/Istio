using k8s.Models;
using Neuroglia.K8s;

namespace Neuroglia.Istio.Resources
{

    /// <summary>
    /// Represents the <see href="https://istio.io/latest/docs/reference/config/networking/virtual-service/">virtual service specification</see>, which is a configuration affecting traffic routing.
    /// </summary>
    public class VirtualService
        : CustomResource<VirtualServiceSpec>
    {

        /// <summary>
        /// Initializes a new <see cref="VirtualService"/>
        /// </summary>
        public VirtualService()
            : base(IstioDefaults.Resources.VirtualService)
        {

        }

        /// <summary>
        /// Initializes a new <see cref="VirtualService"/>
        /// </summary>
        /// <param name="metadata">The <see cref="VirtualService"/>'s <see cref="V1ObjectMeta"/></param>
        /// <param name="spec">The <see cref="VirtualService"/>'s <see cref="VirtualServiceSpec"/></param>
        public VirtualService(V1ObjectMeta metadata, VirtualServiceSpec spec)
            : this()
        {
            this.Metadata = metadata;
            this.Spec = spec;
        }

        /// <summary>
        /// Initializes a new <see cref="VirtualService"/>
        /// </summary>
        /// <param name="metadata">The <see cref="VirtualService"/>'s <see cref="V1ObjectMeta"/></param>
        public VirtualService(V1ObjectMeta metadata)
            : this(metadata, null)
        {
           
        }

        /// <summary>
        /// Initializes a new <see cref="VirtualService"/>
        /// </summary>
        /// <param name="spec">The <see cref="VirtualService"/>'s <see cref="VirtualServiceSpec"/></param>
        public VirtualService(VirtualServiceSpec spec)
            : this(null, spec)
        {
            
        }

        /// <inheritdoc/>
        public override void Validate()
        {
            base.Validate();
            this.Spec?.Validate();
        }

    }

}
