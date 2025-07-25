using System;

using F10Y.T0003;

using IApplicabilities_General = F10Y.Z0008.IApplicabilities;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IApplicabilitySearchDescriptors
    {
        /// <inheritdoc cref="IApplicabilities_General.All"/>
        public ApplicabilitySearchDescriptor General => Instances.ApplicabilitySearchDescriptorOperator.From(
            Instances.Applicabilities.General);
    }
}
