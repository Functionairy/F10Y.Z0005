using System;


namespace F10Y.Z0005
{
    public class Domains : IDomainNames
    {
        #region Infrastructure

        public static IDomainNames Instance { get; } = new Domains();


        private Domains()
        {
        }

        #endregion
    }
}
