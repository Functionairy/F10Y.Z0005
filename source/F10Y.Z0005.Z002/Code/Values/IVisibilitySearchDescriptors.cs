using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface IVisibilitySearchDescriptors
    {
        public VisibilitySearchDescriptor Find_Private => Instances.VisibilitySearchDescriptorOperator.From(
            Visibility.Private);

        public VisibilitySearchDescriptor Find_Public => Instances.VisibilitySearchDescriptorOperator.From(
            Visibility.Public);
    }
}
