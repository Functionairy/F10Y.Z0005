using System;

using F10Y.T0003;

using IDomainNames_General = F10Y.Z0008.IDomainNames;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IDomainSearchDescriptors
    {
        /// <inheritdoc cref="IDomainNames_General.CSharp"/>
        public DomainSearchDescriptor Find_CSharp => Instances.DomainSearchDescriptorOperator.From(
            Instances.DomainNames.CSharp);

        /// <inheritdoc cref="IDomainNames_General.Domain_Names"/>
        public DomainSearchDescriptor Find_DomainNames => Instances.DomainSearchDescriptorOperator.From(
            Instances.DomainNames.Domain_Names);

        public DomainSearchDescriptor_Set Find_Examples => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Super,
            Instances.DomainNames.Examples);

        public DomainSearchDescriptor_Set Find_PathAndPathParts => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Super,
            Instances.DomainNames.Paths,
            Instances.DomainNames.PathParts);

        /// <inheritdoc cref="IDomainNames_General.Project"/>
        public DomainSearchDescriptor Find_Project => Instances.DomainSearchDescriptorOperator.From(
            Instances.DomainNames.Project);

        /// <summary>
        /// Find project XML node name domains.
        /// <inheritdoc cref="IDomainNames_General.Project" path="/summary"/>
        /// </summary>
        public DomainSearchDescriptor_Set Find_ProjectXmlNodeNames_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a subset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Sub,
            Instances.DomainNameSets.ProjectFile_XmlNodeNames);

        public DomainSearchDescriptor_Set Find_ProjectXmlNodeNames_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Super,
            Instances.DomainNameSets.ProjectFile_XmlNodeNames);
    }
}
