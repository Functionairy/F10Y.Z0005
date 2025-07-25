using System;


namespace F10Y.Z0005
{
    public class VisibilityDescriptors : IVisibilityDescriptors
    {
        #region Infrastructure

        public static IVisibilityDescriptors Instance { get; } = new VisibilityDescriptors();


        private VisibilityDescriptors()
        {
        }

        #endregion
    }
}
