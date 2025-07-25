using System;

using F10Y.T0003;


namespace F10Y.Z0005
{
    [ValuesMarker]
    public partial interface IInstanceSetFlowDescriptors
    {
        #region .NET Version - Choose

        public InstanceSetFlowDescriptor_NetVersion_Choose Choose_NetStandard2_1 => Instances.InstanceSetFlowDescriptorOperator.Choose_NetVersion(
            Instances.TargetFrameworkMonikers.netstandard2_1);

        public InstanceSetFlowDescriptor_NetVersion_Choose Choose_Net6 => Instances.InstanceSetFlowDescriptorOperator.Choose_NetVersion(
            Instances.TargetFrameworkMonikers.net6_0);

        public InstanceSetFlowDescriptor_NetVersion_Choose Choose_Net8 => Instances.InstanceSetFlowDescriptorOperator.Choose_NetVersion(
            Instances.TargetFrameworkMonikers.net8_0);

        #endregion

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Deprecate"/>
        public InstanceSetFlowDescriptor_Deprecate Deprecate => InstanceSetFlowDescriptor_Deprecate.Instance;

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Librarate"/>
        public InstanceSetFlowDescriptor_Librarate Librarate => InstanceSetFlowDescriptor_Librarate.Instance;

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Port"/>
        public InstanceSetFlowDescriptor_Port Port => InstanceSetFlowDescriptor_Port.Instance;

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Publicize"/>
        public InstanceSetFlowDescriptor_Publicize Publicize => InstanceSetFlowDescriptor_Publicize.Instance;

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Restrict_Dependencies"/>
        public InstanceSetFlowDescriptor_Restrict_Dependencies Restrict_Dependencies => InstanceSetFlowDescriptor_Restrict_Dependencies.Instance;

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Restrict_Domain"/>
        public InstanceSetFlowDescriptor_Restrict_Domain Restrict_Domain => InstanceSetFlowDescriptor_Restrict_Domain.Instance;

        /// <inheritdoc cref="InstanceSetFlowDescriptor_Restrict_Opinions"/>
        public InstanceSetFlowDescriptor_Restrict_Opinions Restrict_Opinions => InstanceSetFlowDescriptor_Restrict_Opinions.Instance;
    }
}
