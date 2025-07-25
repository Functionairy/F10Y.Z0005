using System;


namespace F10Y.Z0005.Z001
{
    public class DependencySetDescriptors : IDependencySetDescriptors
    {
        #region Infrastructure

        public static IDependencySetDescriptors Instance { get; } = new DependencySetDescriptors();


        private DependencySetDescriptors()
        {
        }

        #endregion
    }
}
