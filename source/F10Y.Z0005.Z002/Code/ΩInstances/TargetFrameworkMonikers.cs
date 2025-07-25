using System;


namespace F10Y.Z0005.Z002
{
    public class TargetFrameworkMonikers : ITargetFrameworkMonikers
    {
        #region Infrastructure

        public static ITargetFrameworkMonikers Instance { get; } = new TargetFrameworkMonikers();


        private TargetFrameworkMonikers()
        {
        }

        #endregion
    }
}
