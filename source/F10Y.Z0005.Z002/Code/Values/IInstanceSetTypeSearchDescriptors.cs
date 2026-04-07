using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IInstanceSetTypeSearchDescriptors
    {
        InstanceSetTypeSearchDescriptor_Name Find_CatchAllLibraries => Instances.InstanceSetTypeSearchDescriptorOperator.From(
            Instances.InstanceSetTypeNames.CatchAll_Library,
            Instances.EqualityOperationDescriptors.Simple);

        InstanceSetTypeSearchDescriptor_Name Find_EntryPoint_Executable => Instances.InstanceSetTypeSearchDescriptorOperator.From(
            Instances.InstanceSetTypeNames.EntryPoint_Executable,
            Instances.EqualityOperationDescriptors.Simple);

        InstanceSetTypeSearchDescriptor_Name Find_FoundationLibraries => Instances.InstanceSetTypeSearchDescriptorOperator.From(
            Instances.InstanceSetTypeNames.Foundation_Library,
            Instances.EqualityOperationDescriptors.Simple);
    }
}
