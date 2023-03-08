using System;

using R5T.T0131;
using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0031
{
    [ValuesMarker]
    public partial interface IKindMarkedFullMemberNames : IValuesMarker
    {

    }
}


namespace R5T.Z0031.Raw
{
    [ValuesMarker]
    public partial interface IKindMarkedFullMemberNames : IValuesMarker
    {
        /// <summary>
        /// Value:
        /// <para>
        /// M:R5T.F0007.IIndentationGenerator.ForClass();Microsoft.CodeAnalysis.SyntaxTriviaList
        /// </para>
        /// </summary>
        public KindMarkedFullMemberName Method_0001 => "M:R5T.F0007.IIndentationGenerator.ForClass();Microsoft.CodeAnalysis.SyntaxTriviaList".ToKindMarkedFullMemberName();

        /// <summary>
        /// Value:
        /// <para>
        /// M:R5T.F0007.IIndentationGenerator&lt;Node&gt;.ForClass&lt;TClass&gt;(TNode node, TClass class, System.Collections.Generic.List{string} values);Microsoft.CodeAnalysis.SyntaxTriviaList
        /// </para>
        /// </summary>
        public KindMarkedFullMemberName Method_0002 => "M:R5T.F0007.IIndentationGenerator<TNode>.ForClass<TClass>(TNode node, TClass class, System.Collections.Generic.List<string> values);Microsoft.CodeAnalysis.SyntaxTriviaList".ToKindMarkedFullMemberName();

        /// <summary>
        /// Value:
        /// <para>
        /// M:R5T.F0007.IIndentationGenerator&lt;TNode&gt;.ForClass&lt;TClass, TType&gt;(TNode node, TClass class, System.Collections.Generic.List&lt;TType&gt; values);Microsoft.CodeAnalysis.SyntaxTriviaList
        /// </para>
        /// </summary>
        public KindMarkedFullMemberName Method_0003 => "M:R5T.F0007.IIndentationGenerator<TNode>.ForClass<TClass, TType>(TNode node, TClass class, System.Collections.Generic.List<TType> values);Microsoft.CodeAnalysis.SyntaxTriviaList".ToKindMarkedFullMemberName();

        /// <summary>
        /// Value:
        /// <para>
        /// M:R5T.F0007.IIndentationGenerator&lt;TNode&gt;.ForClass&lt;TClass, TType&gt;(TNode node, TClass class, System.Collections.Generic.Dictionary&lt;string, TType&gt; values);Microsoft.CodeAnalysis.SyntaxTriviaList
        /// </para>
        /// </summary>
        public KindMarkedFullMemberName Method_0004 => "M:R5T.F0007.IIndentationGenerator<TNode>.ForClass<TClass, TType>(TNode node, TClass class, System.Collections.Generic.Dictionary<string, TType> values);Microsoft.CodeAnalysis.SyntaxTriviaList".ToKindMarkedFullMemberName();
    }
}
