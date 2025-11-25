using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z001
{
    /// <summary>
    /// Generally-applicable instance variety descriptors (for instance sets, i.e. the instance variety facet for an instance set).
    /// </summary>
    [ValuesMarker]
    public partial interface IInstanceVarietyDescriptors
    {
        InstanceVarietyDescriptor_Name_Set Functions_Values => Instances.InstanceVarietyDescriptorOperator.From_Names(
            Instances.InstanceVarietyNames.Functions,
            Instances.InstanceVarietyNames.Values);

        InstanceVarietyDescriptor_Name_Set Functions_Values_UtilityTypes => Instances.InstanceVarietyDescriptorOperator.From_Names(
            Instances.InstanceVarietyNames.Functions,
            Instances.InstanceVarietyNames.Values,
            Instances.InstanceVarietyNames.UtilityTypes);

        InstanceVarietyDescriptor_Name RazorComponents => Instances.InstanceVarietyDescriptorOperator.From_Name(
            Instances.InstanceVarietyNames.RazorComponents);

        InstanceVarietyDescriptor_Values Values_Unadorned_Absolute_Direct => Instances.InstanceVarietyDescriptorOperator.From(
            TypingScheme.Unadorned,
            NamingScheme.Absolute,
            ImplementationScheme.Direct);
    }
}
