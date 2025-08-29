using System;

using F10Y.T0003;


namespace F10Y.Z0005
{
    /// <summary>
    /// Instance set functionality domains.
    /// </summary>
    /// <remarks>
    /// <inheritdoc cref="Documentation.Project_SelfDescription" path="/summary"/>
    /// <para>
    /// This library contains the facet descriptors of instance sets, as values.
    /// If you want the <em>values</em> of the facet descriptors of instance sets, see <see cref="Z0008.IDomains"/>.
    /// </para>
    /// </remarks>
    [ValuesMarker]
    public partial interface IDomains :
        Z0008.IDomains
    {
#pragma warning disable IDE1006 // Naming Styles

        public Z0008.IDomains _Z0008 => Z0008.Domains.Instance;

#pragma warning restore IDE1006 // Naming Styles


        /// <summary>
        /// <para><value>Instance Set-Machinery</value></para>
        /// </summary>
        public string InstanceSet_Machinery => "Instance Set-Machinery";

        /// <summary>
        /// <para><value>Instance Set Search-Machinery</value></para>
        /// </summary>
        public string InstanceSetSearch_Machinery => "Instance Set Search-Machinery";
    }
}
