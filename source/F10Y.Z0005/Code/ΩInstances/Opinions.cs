using System;


namespace F10Y.Z0005
{
    public class Opinions : IOpinions
    {
        #region Infrastructure

        public static IOpinions Instance { get; } = new Opinions();


        private Opinions()
        {
        }

        #endregion
    }
}
