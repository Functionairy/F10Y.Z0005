using System;


namespace F10Y.Z0005
{
    public class InstanceSetFlowDescriptors : IInstanceSetFlowDescriptors
    {
        #region Infrastructure

        public static IInstanceSetFlowDescriptors Instance { get; } = new InstanceSetFlowDescriptors();


        private InstanceSetFlowDescriptors()
        {
        }

        #endregion
    }
}
