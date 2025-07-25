using System;

using F10Y.T0002;

using ITargetFrameworkMonikers_F10Y_L0008_Z000 = F10Y.L0008.Z000.ITargetFrameworkMonikers;


namespace F10Y.Z0005.Z002
{
    [FunctionsMarker]
    public partial interface INetVersionSearchDescriptors
    {
        /// <summary>
        /// <see cref="ITargetFrameworkMonikers_F10Y_L0008_Z000.LATEST"/>
        /// </summary>
        public NetVersionSearchDescriptor Find_LATEST_AsGeneralType => Instances.NetVersionSearchDescriptorOperator.From(
            Instances.TargetFrameworkMonikers.LATEST);

        /// <summary>
        /// <see cref="Z0002.ITargetFrameworkMonikers.netstandard2_1"/>
        /// </summary>
        public NetVersionSearchDescriptor Find_netstandard2_1 => Instances.NetVersionSearchDescriptorOperator.From(
            Instances.TargetFrameworkMonikers.netstandard2_1);

        /// <summary>
        /// <see cref="Z0002.ITargetFrameworkMonikers.netstandard2_1"/>
        /// </summary>
        public NetVersionSearchDescriptor Find_net6_0 => Instances.NetVersionSearchDescriptorOperator.From(
            Instances.TargetFrameworkMonikers.net6_0);

        /// <summary>
        /// <see cref="Z0002.ITargetFrameworkMonikers.netstandard2_1"/>
        /// </summary>
        public NetVersionSearchDescriptor Find_net8_0 => Instances.NetVersionSearchDescriptorOperator.From(
            Instances.TargetFrameworkMonikers.net8_0);
    }
}
