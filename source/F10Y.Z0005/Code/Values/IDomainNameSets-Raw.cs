using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005.Raw
{
    [ValuesMarker]
    public partial interface IDomainNameSets :
        Z0008.Raw.IDomainNameSets
    {
#pragma warning disable IDE1006 // Naming Styles

        private static IDomainNames _Domains => Domains.Instance;


        [Ignore]
        Z0008.Raw.IDomainNameSets _Z0008 => Z0008.Raw.DomainNameSets.Instance;

#pragma warning restore IDE1006 // Naming Styles


        
    }
}
