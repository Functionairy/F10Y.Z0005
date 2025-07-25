using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface ITargetFrameworkMonikers :
        L0008.Z000.ITargetFrameworkMonikers,
        Z0002.ITargetFrameworkMonikers
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public L0008.Z000.ITargetFrameworkMonikers _L0008_Z000 => L0008.Z000.TargetFrameworkMonikers.Instance;

        [Ignore]
        public Z0002.ITargetFrameworkMonikers _Z0002 => Z0002.TargetFrameworkMonikers.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
