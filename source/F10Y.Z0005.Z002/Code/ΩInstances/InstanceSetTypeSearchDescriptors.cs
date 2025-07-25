using System;


namespace F10Y.Z0005.Z002
{
    public class InstanceSetTypeSearchDescriptors : IInstanceSetTypeSearchDescriptors
    {
        #region Infrastructure

        public static IInstanceSetTypeSearchDescriptors Instance { get; } = new InstanceSetTypeSearchDescriptors();


        private InstanceSetTypeSearchDescriptors()
        {
        }

        #endregion
    }
}
