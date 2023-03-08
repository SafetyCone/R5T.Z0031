using System;

using R5T.T0131;
using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0031
{
    [ValuesMarker]
    public partial interface ITypeNames : IValuesMarker
    {

    }
}


namespace R5T.Z0031.Raw
{
    [ValuesMarker]
    public partial interface ITypeNames : IValuesMarker
    {
        public TypeName ReturnType_ForMethod0001 => "Microsoft.CodeAnalysis.SyntaxTriviaList".ToTypeName();
    }
}
