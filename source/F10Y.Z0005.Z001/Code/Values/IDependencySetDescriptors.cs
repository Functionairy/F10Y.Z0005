using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z001
{
    /// <summary>
    /// Generally-applicable dependency set descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDependencySetDescriptors
    {
        /// <summary>
        /// Only instance marker types are allowed as dependencies.
        /// </summary>
        public DependencySetDescriptor_Constrained Markers_Only => Instances.DependencySetDescriptorOperator.Constrained_To(
            Instances.ContextNames.Markers_Only);

        /// <inheritdoc cref="DependencySetDescriptor_None"/>
        public DependencySetDescriptor_None None => DependencySetDescriptor_None.Instance;

        /// <inheritdoc cref="DependencySetDescriptor_Unconstrained"/>
        public DependencySetDescriptor_Unconstrained Unconstrained => DependencySetDescriptor_Unconstrained.Instance;
    }
}
