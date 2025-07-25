using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005.Raw
{
    [ValuesMarker]
    public partial interface IDomainSets :
        Z0008.Raw.IDomainSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDomains _Domains => Domains.Instance;


        [Ignore]
        public Z0008.Raw.IDomainSets _Z0008 => Z0008.Raw.DomainSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
