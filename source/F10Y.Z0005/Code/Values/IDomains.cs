using System;

using F10Y.T0003;


namespace F10Y.Z0005
{
    [ValuesMarker]
    public partial interface IDomains :
        Z0008.IDomains
    {
#pragma warning disable IDE1006 // Naming Styles

        public Z0008.IDomains _Z0008 => Z0008.Domains.Instance;

#pragma warning restore IDE1006 // Naming Styles
    }
}
