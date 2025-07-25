using System;

using F10Y.T0003;


namespace F10Y.Z0005.Z002
{
    [ValuesMarker]
    public partial interface ITypingSchemeSearchDescriptors
    {
        /// <inheritdoc cref="TypingScheme.Decorated"/>
        public TypingSchemeSearchDescriptor_Enumeration Decorated => Instances.TypingSchemeSearchDescriptorOperator.From(
            TypingScheme.Decorated);

        /// <inheritdoc cref="TypingScheme.Unadorned"/>
        public TypingSchemeSearchDescriptor_Enumeration Unadorned => Instances.TypingSchemeSearchDescriptorOperator.From(
            TypingScheme.Unadorned);
    }
}
