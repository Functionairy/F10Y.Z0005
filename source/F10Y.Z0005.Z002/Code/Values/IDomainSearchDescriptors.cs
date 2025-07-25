using System;

using F10Y.T0003;

using IDomains_General = F10Y.Z0008.IDomains;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IDomainSearchDescriptors
    {
        /// <inheritdoc cref="IDomains_General.CSharp"/>
        public DomainSearchDescriptor Find_CSharp => Instances.DomainSearchDescriptorOperator.From(
            Instances.Domains.CSharp);

        public DomainSearchDescriptor_Set Find_Examples => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Super,
            Instances.Domains.Examples);

        public DomainSearchDescriptor_Set Find_PathAndPathParts => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Super,
            Instances.Domains.Paths,
            Instances.Domains.PathParts);

        /// <inheritdoc cref="IDomains_General.Project"/>
        public DomainSearchDescriptor Find_Project => Instances.DomainSearchDescriptorOperator.From(
            Instances.Domains.Project);

        /// <summary>
        /// Find project XML node name domains.
        /// <inheritdoc cref="IDomains_General.Project" path="/summary"/>
        /// </summary>
        public DomainSearchDescriptor_Set Find_ProjectXmlNodeNames_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a subset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Sub,
            Instances.DomainSets.ProjectFile_XmlNodeNames);

        public DomainSearchDescriptor_Set Find_ProjectXmlNodeNames_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.Super,
            Instances.DomainSets.ProjectFile_XmlNodeNames);
    }
}
