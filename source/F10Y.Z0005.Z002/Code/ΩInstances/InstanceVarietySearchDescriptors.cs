using System;


namespace F10Y.Z0005.Z002
{
    public class InstanceVarietySearchDescriptors : IInstanceVarietySearchDescriptors
    {
        #region Infrastructure

        public static IInstanceVarietySearchDescriptors Instance { get; } = new InstanceVarietySearchDescriptors();


        private InstanceVarietySearchDescriptors()
        {
        }

        #endregion
    }
}
