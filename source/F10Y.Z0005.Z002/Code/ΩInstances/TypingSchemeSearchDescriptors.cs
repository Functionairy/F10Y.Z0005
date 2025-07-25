using System;


namespace F10Y.Z0005.Z002
{
    public class TypingSchemeSearchDescriptors : ITypingSchemeSearchDescriptors
    {
        #region Infrastructure

        public static ITypingSchemeSearchDescriptors Instance { get; } = new TypingSchemeSearchDescriptors();


        private TypingSchemeSearchDescriptors()
        {
        }

        #endregion
    }
}
