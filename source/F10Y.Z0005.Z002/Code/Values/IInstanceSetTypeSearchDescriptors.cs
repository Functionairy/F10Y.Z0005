using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeSearchDescriptors
    {
        public InstanceSetTypeSearchDescriptor_Name Find_CatchAllLibraries => Instances.InstanceSetTypeSearchDescriptorOperator.From(
            Instances.InstanceSetTypeNames.CatchAll_Library,
            Instances.EqualityOperationDescriptors.For_String_Simple);

        public InstanceSetTypeSearchDescriptor_Name Find_FoundationLibraries => Instances.InstanceSetTypeSearchDescriptorOperator.From(
            Instances.InstanceSetTypeNames.Foundation_Library,
            Instances.EqualityOperationDescriptors.For_String_Simple);
    }
}
