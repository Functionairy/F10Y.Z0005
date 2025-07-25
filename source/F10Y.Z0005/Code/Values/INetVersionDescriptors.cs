using System;

using F10Y.T0003;
using F10Y.T0011;

using ITargetFrameworkMonikers_F10Y_Z0002 = F10Y.Z0002.ITargetFrameworkMonikers;


namespace F10Y.Z0005
{
    [ValuesMarker]
    public partial interface INetVersionDescriptors :
        L0026.T001.INetVersionDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0026.T001.INetVersionDescriptors _L0026_T001 => L0026.T001.NetVersionDescriptors.Instance;


        /// <inheritdoc cref="ITargetFrameworkMonikers_F10Y_Z0002.netstandard2_1"/>
        public NetVersionDescriptor netstandard2_1 => Instances.NetVersionDescriptorOperator.From(Instances.TargetFrameworkMonikers.netstandard2_1);

        /// <inheritdoc cref="ITargetFrameworkMonikers_F10Y_Z0002.net6_0"/>
        public NetVersionDescriptor net6
            => Instances.NetVersionDescriptorOperator.From(Instances.TargetFrameworkMonikers.net6_0);

        /// <inheritdoc cref="ITargetFrameworkMonikers_F10Y_Z0002.net8_0"/>
        public NetVersionDescriptor net8
            => Instances.NetVersionDescriptorOperator.From(Instances.TargetFrameworkMonikers.net8_0);

#pragma warning restore IDE1006 // Naming Styles
    }
}
