using System;


namespace F10Y.Z0005.Z002
{
    public class ApplicabilitySearchDescriptors : IApplicabilitySearchDescriptors
    {
        #region Infrastructure

        public static IApplicabilitySearchDescriptors Instance { get; } = new ApplicabilitySearchDescriptors();


        private ApplicabilitySearchDescriptors()
        {
        }

        #endregion
    }
}
