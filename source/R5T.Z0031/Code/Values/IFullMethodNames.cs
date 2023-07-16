using System;

using R5T.T0131;
using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0031
{
    [ValuesMarker]
    public partial interface IFullMethodNames : IValuesMarker
    {

    }
}


namespace R5T.Z0031.Raw
{
    [ValuesMarker]
    public partial interface IFullMethodNames : IValuesMarker
    {
        public IFullMethodName For_Method_0001 => "R5T.F0007.IIndentationGenerator.ForClass();Microsoft.CodeAnalysis.SyntaxTriviaList".ToFullMethodName();
        public IFullMethodName For_Method_0003 => "R5T.F0007.IIndentationGenerator<TNode>.ForClass<TClass, TType>(TNode node, TClass class, System.Collections.Generic.List<TType> values);Microsoft.CodeAnalysis.SyntaxTriviaList".ToFullMethodName();
        public IFullMethodName For_Method_0004 => "R5T.F0007.IIndentationGenerator<TNode>.ForClass<TClass, TType>(TNode node, TClass class, System.Collections.Generic.Dictionary<string, TType> values);Microsoft.CodeAnalysis.SyntaxTriviaList".ToFullMethodName();
    }
}
