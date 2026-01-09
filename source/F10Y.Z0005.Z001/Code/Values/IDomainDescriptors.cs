using System;

using F10Y.T0003;

using IDomainNames_General = F10Y.Z0008.IDomainNames;
using IDomainNameSets_General = F10Y.Z0008.IDomainNameSets;


namespace F10Y.Z0005.Z001 /// <see cref="Documentation"/>
{
    /// <summary>
    /// Generally-applicable domain descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="IDomainNameSets_General.CSharp_NET"/>
        DomainDescriptor_Set CSharp_NET => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainNameSets.CSharp_NET);

        /// <inheritdoc cref="IDomainNames_General.dotNET"/>
        DomainDescriptor_Set dotNET => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainNames.dotNET);

        /// <inheritdoc cref="IDomainNameSets_General.Example_PathsAndPathParts"/>
        DomainDescriptor_Set Example_PathsAndPathParts => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainNameSets.Example_PathsAndPathParts);

        /// <inheritdoc cref="IDomainNameSets_General.ProjectFile_XmlNodeNames"/>
        DomainDescriptor_Set ProjectFile_XmlNodeNames => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainNameSets.ProjectFile_XmlNodeNames);

        DomainDescriptor StaticHtml => Instances.DomainDescriptorOperator.From_Domain(
            Instances.DomainNames.StaticHtml);

#pragma warning restore IDE1006 // Naming Styles
    }
}
