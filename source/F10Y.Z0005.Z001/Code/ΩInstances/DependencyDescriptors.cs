using System;


namespace F10Y.Z0005.Z001
{
    public class DependencyDescriptors : IDependencyDescriptors
    {
        #region Infrastructure

        public static IDependencyDescriptors Instance { get; } = new DependencyDescriptors();


        private DependencyDescriptors()
        {
        }

        #endregion
    }
}
