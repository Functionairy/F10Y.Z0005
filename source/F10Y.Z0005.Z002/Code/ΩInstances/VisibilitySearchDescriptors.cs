using System;


namespace F10Y.Z0005.Z002
{
    public class VisibilitySearchDescriptors : IVisibilitySearchDescriptors
    {
        #region Infrastructure

        public static IVisibilitySearchDescriptors Instance { get; } = new VisibilitySearchDescriptors();


        private VisibilitySearchDescriptors()
        {
        }

        #endregion
    }
}
