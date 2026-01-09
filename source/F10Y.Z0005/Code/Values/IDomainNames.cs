using System;

using F10Y.T0003;
using F10Y.T0011;


namespace F10Y.Z0005
{
    /// <summary>
    /// Instance set functionality domain names.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// <para>
    /// This library contains the facet descriptors of instance sets, as values.
    /// If you want the <em>values</em> of the facet descriptors of instance sets, see <see cref="Z0008.IDomainNames"/>.
    /// </para>
    /// </remarks>
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Domain_Names_Constant)]
    public partial interface IDomainNames :
        Z0008.IDomainNames
    {
#pragma warning disable IDE1006 // Naming Styles

        [Ignore]
        Z0008.IDomainNames _Z0008 => Z0008.DomainNames.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>Instance Set-Machinery</value></para>
        /// </summary>
        string InstanceSet_Machinery => "Instance Set-Machinery";

        /// <summary>
        /// <para><value>Instance Set Search-Machinery</value></para>
        /// </summary>
        string InstanceSetSearch_Machinery => "Instance Set Search-Machinery";
    }
}
