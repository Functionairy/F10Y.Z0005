using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005
{
    [ValuesMarker]
    public partial interface IDomainNameSets :
        Z0008.IDomainNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public new Raw.IDomainNameSets _Raw => Raw.DomainSets.Instance;

        [Ignore]
        public Z0008.IDomainNameSets _Z0008 => Z0008.DomainNameSets.Instance;

#pragma warning restore IDE1006 // Naming Styles



    }
}
