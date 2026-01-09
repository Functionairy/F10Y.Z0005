using System;


namespace F10Y.Z0005
{
    public class DomainSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainSets();


        private DomainSets()
        {
        }

        #endregion
    }
}


namespace F10Y.Z0005.Raw
{
    public class DomainSets : IDomainNameSets
    {
        #region Infrastructure

        public static IDomainNameSets Instance { get; } = new DomainSets();


        private DomainSets()
        {
        }

        #endregion
    }
}
