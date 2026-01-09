using System;


namespace F10Y.Z0005.Z001
{
    public static class Instances
    {
        public static Z0008.IContextNames ContextNames => Z0008.ContextNames.Instance;
        public static L0026.T001.IDependencyDescriptorOperator DependencyDescriptorOperator => L0026.T001.DependencyDescriptorOperator.Instance;
        public static L0026.T001.IDependencySetDescriptorOperator DependencySetDescriptorOperator => L0026.T001.DependencySetDescriptorOperator.Instance;
        /// <inheritdoc cref="IDependencyDescriptors"/>
        public static IDependencyDescriptors DependencyDescriptors => Z001.DependencyDescriptors.Instance;
        public static L0026.T001.IDomainDescriptorOperator DomainDescriptorOperator => L0026.T001.DomainDescriptorOperator.Instance;
        /// <inheritdoc cref="Z0008.IDomainNames"/>
        public static Z0008.IDomainNames DomainNames => Z0008.DomainNames.Instance;
        /// <inheritdoc cref="Z0008.IDomainNameSets"/>
        public static Z0008.IDomainNameSets DomainNameSets => Z0008.DomainNameSets.Instance;
        public static L0026.T003.IInstanceVarietyDescriptorOperator InstanceVarietyDescriptorOperator => L0026.T003.InstanceVarietyDescriptorOperator.Instance;
        public static Z0008.IInstanceVarietyNames InstanceVarietyNames => Z0008.InstanceVarietyNames.Instance;
    }
}