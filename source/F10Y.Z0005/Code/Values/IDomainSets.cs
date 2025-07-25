using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005
{
    [ValuesMarker]
    public partial interface IDomainSets :
        Z0008.IDomainSets
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        public new Raw.IDomainSets _Raw => Raw.DomainSets.Instance;

        [Ignore]
        public Z0008.IDomainSets _Z0008 => Z0008.DomainSets.Instance;

#pragma warning restore IDE1006 // Naming Styles



    }
}
