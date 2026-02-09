using System;

using F10Y.T0003;

using IDomainNames_General = F10Y.Z0008.IDomainNames;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IDomainSearchDescriptors
    {
        /// <inheritdoc cref="IDomainNames_General.CSharp"/>
        DomainSearchDescriptor Find_CSharp => Instances.DomainSearchDescriptorOperator.From(
            Instances.DomainNames.CSharp);

        /// <inheritdoc cref="IDomainNames_General.Domain_Names"/>
        DomainSearchDescriptor Find_DomainNames => Instances.DomainSearchDescriptorOperator.From(
            Instances.DomainNames.Domain_Names);

        DomainSearchDescriptor_Set Find_Examples => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNames.Examples);

        DomainSearchDescriptor_Set Find_PathAndPathParts => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNames.Paths,
            Instances.DomainNames.PathParts);

        /// <inheritdoc cref="IDomainNames_General.Project"/>
        DomainSearchDescriptor Find_Project => Instances.DomainSearchDescriptorOperator.From(
            Instances.DomainNames.Project);

        /// <summary>
        /// Find project XML node name domains.
        /// <inheritdoc cref="IDomainNames_General.Project" path="/summary"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_ProjectXmlNodeNames_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a subset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.BSubsetOfA,
            Instances.DomainNameSets.ProjectFile_XmlNodeNames);

        /// <summary>
        /// Find subsets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXmlNodeNames" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXmlNodeNames_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a subset of the domain name set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.BSubsetOfA,
            Instances.DomainNameSets.dotNETProjectXmlNodeNames);

        /// <summary>
        /// Find subsets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXmlElementNames" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXmlElementNames_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a subset of the domain name set of the instance set search descriptor? (Does the search descriptor's value set contain ALL the values from the instance descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSubsetOfA,
            Instances.DomainNameSets.dotNETProjectXmlElementNames);

        /// <summary>
        /// Find subsets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXmlElementNames" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXml_Names_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a subset of the domain name set of the instance set search descriptor? (Does the search descriptor's value set contain ALL the values from the instance descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSubsetOfA,
            Instances.DomainNameSets.dotNETProjectXml_Names);

        /// <summary>
        /// Find supersets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXmlElementNames" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXml_Names_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a subset of the domain name set of the instance set search descriptor? (Does the instance descriptor's value set contain ALL the values from the search descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNameSets.dotNETProjectXml_Names);

        DomainSearchDescriptor_Set Find_ProjectXmlNodeNames_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain set of the instance set a superset of the domain set of the instance set search descriptor?
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNameSets.ProjectFile_XmlNodeNames);


        /// <summary>
        /// Find subsets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXmlNodeNamesTest" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXmlNodeNamesTest_Subsets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a subset of the domain name set of the instance set search descriptor? (Does the search descriptor's value set contain ALL the values from the instance descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSubsetOfA,
            Instances.DomainNameSets.dotNETProjectXmlNodeNamesTest);

        /// <summary>
        /// Find supersets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXmlNodeNamesTest" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXmlNodeNamesTest_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a subset of the domain name set of the instance set search descriptor? (Does the instance descriptor's value set contain ALL the values from the search descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNameSets.dotNETProjectXmlNodeNamesTest);

        /// <summary>
        /// Find supersets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.dotNETProjectXml" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_dotNETProjectXml_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a superset of the domain name set of the instance set search descriptor? (Does the instance descriptor's value set contain ALL the values from the search descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNameSets.dotNETProjectXml);

        /// <summary>
        /// Find supersets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.EqualityOperationDescriptor" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_EqualityOperationDescriptor_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a superset of the domain name set of the instance set search descriptor? (Does the instance descriptor's value set contain ALL the values from the search descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNameSets.EqualityOperationDescriptor);

        /// <summary>
        /// Find supersets of the domain set:
        /// <inheritdoc cref="Z0008.IDomainNameSets.SetEqualityOperationDescriptor" path="descendant::value[1]"/>
        /// </summary>
        DomainSearchDescriptor_Set Find_SetEqualityOperationDescriptor_Supersets => Instances.DomainSearchDescriptorOperator.From(
            // Is the domain name set of an instance set a superset of the domain name set of the instance set search descriptor? (Does the instance descriptor's value set contain ALL the values from the search descriptor's set?)
            Instances.SetEqualityOperationDescriptors.BSupersetOfA,
            Instances.DomainNameSets.SetEqualityOperationDescriptor);
    }
}
