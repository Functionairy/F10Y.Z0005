using System;


namespace F10Y.Z0005.Z002
{
    public class ImplementationSchemeSearchDescriptors : IImplementationSchemeSearchDescriptors
    {
        #region Infrastructure

        public static IImplementationSchemeSearchDescriptors Instance { get; } = new ImplementationSchemeSearchDescriptors();


        private ImplementationSchemeSearchDescriptors()
        {
        }

        #endregion
    }
}
