using System;


namespace F10Y.Z0005.Z002
{
    public class NamingSchemeSearchDescriptors : INamingSchemeSearchDescriptors
    {
        #region Infrastructure

        public static INamingSchemeSearchDescriptors Instance { get; } = new NamingSchemeSearchDescriptors();


        private NamingSchemeSearchDescriptors()
        {
        }

        #endregion
    }
}
