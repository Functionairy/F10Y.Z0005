using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005
{
    /// <summary>
    /// Generally-applicable domain descriptors.
    /// </summary>
    [ValuesMarker]
    public partial interface IDomainDescriptors :
        Z001.IDomainDescriptors
    {
#pragma warning disable IDE1006 // Naming Styles

        /// <inheritdoc cref="Z001.IDomainDescriptors"/>
        [Ignore]
        public Z001.IDomainDescriptors _Z001 => Z001.DomainDescriptors.Instance;

#pragma warning restore IDE1006 // Naming Styles


    }
}
