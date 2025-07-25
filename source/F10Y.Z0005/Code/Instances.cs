using System;


namespace F10Y.Z0005
{
    public static class Instances
    {
        public static L0026.T001.IDomainDescriptorOperator DomainDescriptorOperator => L0026.T001.DomainDescriptorOperator.Instance;
        public static IDomainSets DomainSets => Z0005.DomainSets.Instance;
        public static L0026.T003.IInstanceSetFlowDescriptorOperator InstanceSetFlowDescriptorOperator => L0026.T003.InstanceSetFlowDescriptorOperator.Instance;
        public static L0026.T001.INetVersionDescriptorOperator NetVersionDescriptorOperator => L0026.T001.NetVersionDescriptorOperator.Instance;
        public static Z0002.ITargetFrameworkMonikers TargetFrameworkMonikers => Z0002.TargetFrameworkMonikers.Instance;
        public static L0026.T001.IVisibilityDescriptorOperator VisibilityDescriptorOperator => L0026.T001.VisibilityDescriptorOperator.Instance;
    }
}