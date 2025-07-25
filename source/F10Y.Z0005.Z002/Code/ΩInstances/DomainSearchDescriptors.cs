using System;


namespace F10Y.Z0005.Z002
{
    public class DomainSearchDescriptors : IDomainSearchDescriptors
    {
        #region Infrastructure

        public static IDomainSearchDescriptors Instance { get; } = new DomainSearchDescriptors();


        private DomainSearchDescriptors()
        {
        }

        #endregion
    }
}
