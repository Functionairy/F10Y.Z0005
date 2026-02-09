using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005.Z001
{
    /// <summary>
    /// Generally-applicable instance variety descriptors (for instance sets, i.e. the instance variety facet for an instance set).
    /// </summary>
    [ValuesMarker]
    public partial interface IInstanceVarietyDescriptors :
        L0026.T003.IInstanceVarietyDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        L0026.T003.IInstanceVarietyDescriptors _L0026_T003 => L0026.T003.InstanceVarietyDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


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
