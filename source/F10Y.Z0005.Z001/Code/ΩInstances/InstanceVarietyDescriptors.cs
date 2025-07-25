using System;


namespace F10Y.Z0005.Z001
{
    public class InstanceVarietyDescriptors : IInstanceVarietyDescriptors
    {
        #region Infrastructure

        public static IInstanceVarietyDescriptors Instance { get; } = new InstanceVarietyDescriptors();


        private InstanceVarietyDescriptors()
        {
        }

        #endregion
    }
}
