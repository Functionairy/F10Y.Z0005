using System;

using F10Y.T0003;


namespace F10Y.Z0005
{
    [ValuesMarker]
    [DomainDescriptor(Z0008.IDomainNames.Opinion_Names_Constant)]
    public partial interface IOpinions
    {
        /// <summary>
        /// <para><value>Context Based</value></para>
        /// </summary>
        string Context_Based => "Context Based";

        /// <summary>
        /// <para><value>IHasX Based</value></para>
        /// </summary>
        string IHasX_Based => "IHasX Based";

        /// <summary>
        /// <para><value>IHasX/IWithX Based</value></para>
        /// </summary>
        string IHasX_IWithX_Based => "IHasX/IWithX Based";

        /// <summary>
        /// <para><value>Personal</value></para>
        /// </summary>
        string Personal => "Personal";

        /// <summary>
        /// <para><value>Organizational</value></para>
        /// </summary>
        string Organizational => "Organizational";

        /// <summary>
        /// <para><value>Service Based</value></para>
        /// </summary>
        string Service_Based => "Service Based";

        /// <summary>
        /// <para><value>Strongly Typed</value></para>
        /// </summary>
        string Strongly_Typed => "Strongly Typed";

        /// <summary>
        /// <para><value>TailwindCSSed</value></para>
        /// </summary>
        string TailwindCSSed => "TailwindCSSed";

        /// <summary>
        /// <para><value>Without_RazorFeatures</value></para>
        /// </summary>
        string Without_RazorFeatures => "Without_RazorFeatures";

        /// <summary>
        /// <para><value>Unopinionated</value></para>
        /// </summary>
        const string Unopinionated_Constant = "Unopinionated";

        /// <inheritdoc cref="Unopinionated_Constant"/>
        string Unopinionated => Unopinionated_Constant;
    }
}
