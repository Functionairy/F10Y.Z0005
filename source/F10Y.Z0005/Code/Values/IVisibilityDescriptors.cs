using System;

using F10Y.T0003;


namespace F10Y.Z0005
{
    [ValuesMarker]
    public partial interface IVisibilityDescriptors
    {
        /// <summary>
        /// An invalid visibility descriptor (for testing).
        /// </summary>
        public VisibilityDescriptor_Invalid Invalid => VisibilityDescriptor_Invalid.Instance;

        /// <summary>
        /// For <see cref="Visibility.Private"/>
        /// <para><value><see cref="Visibility.Private"/></value></para>
        /// </summary>
        public VisibilityDescriptor Private => Instances.VisibilityDescriptorOperator.From(Visibility.Private);

        /// <summary>
        /// For <see cref="Visibility.Public"/>
        /// <para><value><see cref="Visibility.Public"/></value></para>
        /// </summary>
        public VisibilityDescriptor Public => Instances.VisibilityDescriptorOperator.From(Visibility.Public);
    }
}
