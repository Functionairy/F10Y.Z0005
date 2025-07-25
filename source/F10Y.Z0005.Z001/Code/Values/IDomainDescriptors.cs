using System;

using F10Y.T0003;

using IDomains_General = F10Y.Z0008.IDomains;
using IDomainSets_General = F10Y.Z0008.IDomainSets;


namespace F10Y.Z0005.Z001 /// <see cref="Documentation"/>
{
    /// <summary>
    /// Generally-applicable domain descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="IDomainSets_General.CSharp_NET"/>
        public DomainDescriptor_Set CSharp_NET => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainSets.CSharp_NET);

        /// <inheritdoc cref="IDomains_General.dotNET"/>
        public DomainDescriptor_Set dotNET => Instances.DomainDescriptorOperator.From_Domains(
            Instances.Domains.dotNET);

        /// <inheritdoc cref="IDomainSets_General.Example_PathsAndPathParts"/>
        public DomainDescriptor_Set Example_PathsAndPathParts => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainSets.Example_PathsAndPathParts);

        /// <inheritdoc cref="IDomainSets_General.ProjectFile_XmlNodeNames"/>
        public DomainDescriptor_Set ProjectFile_XmlNodeNames => Instances.DomainDescriptorOperator.From_Domains(
            Instances.DomainSets.ProjectFile_XmlNodeNames);

#pragma warning restore IDE1006 // Naming Styles
    }
}
