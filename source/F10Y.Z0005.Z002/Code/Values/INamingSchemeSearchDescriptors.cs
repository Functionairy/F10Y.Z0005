using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface INamingSchemeSearchDescriptors
    {
        public NamingSchemeSearchDescriptor_Enumeration Absolute => Instances.NamingSchemeSearchDescriptorOperator.From(
            NamingScheme.Absolute);

        public NamingSchemeSearchDescriptor_Enumeration Contextual => Instances.NamingSchemeSearchDescriptorOperator.From(
            NamingScheme.Contextual);
    }
}
