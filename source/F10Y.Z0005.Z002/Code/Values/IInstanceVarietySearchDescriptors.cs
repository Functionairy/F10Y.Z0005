using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IInstanceVarietySearchDescriptors
    {
        /// <summary>
        /// Find instances of the "<inheritdoc cref="Z0008.IInstanceVarietyNames.DataTypes" path="descendant::value[1]"/>" variety.
        /// </summary>
        InstanceVarietySearchDescriptor_Name DataTypes => Instances.InstanceVarietySearchDescriptorOperator.From(
            Instances.InstanceVarietyNames.DataTypes);

        /// <summary>
        /// Find instances of the "<inheritdoc cref="Z0008.IInstanceVarietyNames.Functions" path="descendant::value[1]"/>" variety.
        /// </summary>
        InstanceVarietySearchDescriptor_Name Functions => Instances.InstanceVarietySearchDescriptorOperator.From(
            Instances.InstanceVarietyNames.Functions);

        /// <summary>
        /// Find instances of the "<inheritdoc cref="Z0008.IInstanceVarietyNames.Scripts" path="descendant::value[1]"/>" variety.
        /// </summary>
        InstanceVarietySearchDescriptor_Name Scripts => Instances.InstanceVarietySearchDescriptorOperator.From(
            Instances.InstanceVarietyNames.Scripts);

        /// <summary>
        /// Find instances of the "<inheritdoc cref="Z0008.IInstanceVarietyNames.Values" path="descendant::value[1]"/>" variety.
        /// </summary>
        InstanceVarietySearchDescriptor_Name Values => Instances.InstanceVarietySearchDescriptorOperator.From(
            Instances.InstanceVarietyNames.Values);

        InstanceVarietySearchDescriptor_Values Values_Absolute_Direct_Unadorned => Instances.InstanceVarietySearchDescriptorOperator.From(
            Instances.NamingSchemeSearchDescriptors.Absolute,
            Instances.ImplementationSchemeSearchDescriptors.Direct,
            Instances.TypingSchemeSearchDescriptors.Unadorned);
    }
}
