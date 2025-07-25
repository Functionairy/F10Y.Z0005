using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z001
{
    /// <summary>
    /// Generally-applicable instance variety descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IInstanceVarietyDescriptors
    {
        public InstanceVarietyDescriptor_Name_Set Functions_Values => Instances.InstanceVarietyDescriptorOperator.From_Names(
            Instances.InstanceVarietyNames.Functions,
            Instances.InstanceVarietyNames.Values);

        public InstanceVarietyDescriptor_Name_Set Functions_Values_UtilityTypes => Instances.InstanceVarietyDescriptorOperator.From_Names(
            Instances.InstanceVarietyNames.Functions,
            Instances.InstanceVarietyNames.Values,
            Instances.InstanceVarietyNames.UtilityTypes);

        public InstanceVarietyDescriptor_Values Values_Unadorned_Absolute_Direct => Instances.InstanceVarietyDescriptorOperator.From(
            TypingScheme.Unadorned,
            NamingScheme.Absolute,
            ImplementationScheme.Direct);
    }
}
