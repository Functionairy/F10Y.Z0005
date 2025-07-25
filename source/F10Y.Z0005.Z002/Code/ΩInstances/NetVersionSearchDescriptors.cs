using System;


namespace F10Y.Z0005.Z002
{
    public class NetVersionSearchDescriptors : INetVersionSearchDescriptors
    {
        #region Infrastructure

        public static INetVersionSearchDescriptors Instance { get; } = new NetVersionSearchDescriptors();


        private NetVersionSearchDescriptors()
        {
        }

        #endregion
    }
}
