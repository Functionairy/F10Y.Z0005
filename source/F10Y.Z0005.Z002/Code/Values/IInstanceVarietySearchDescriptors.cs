using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IInstanceVarietySearchDescriptors
    {
        public InstanceVarietySearchDescriptor_Values Absolute_Direct_Unadorned => Instances.InstanceVarietySearchDescriptorOperator.From(
            Instances.NamingSchemeSearchDescriptors.Absolute,
            Instances.ImplementationSchemeSearchDescriptors.Direct,
            Instances.TypingSchemeSearchDescriptors.Unadorned);
    }
}
