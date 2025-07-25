using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IImplementationSchemeSearchDescriptors
    {
        /// <inheritdoc cref="Derived"/>
        public ImplementationSchemeSearchDescriptor_Enumeration Derived => Instances.ImplementationSchemeSearchDescriptorOperator.From(
            ImplementationScheme.Derived);

        /// <inheritdoc cref="Direct"/>
        public ImplementationSchemeSearchDescriptor_Enumeration Direct => Instances.ImplementationSchemeSearchDescriptorOperator.From(
            ImplementationScheme.Direct);
    }
}
