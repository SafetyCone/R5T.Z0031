using System;

using R5T.T0131;
using R5T.T0161;
using R5T.T0161.Extensions;


namespace R5T.Z0031
{
    [ValuesMarker]
    public partial interface ITypeNamedMethodNames : IValuesMarker
    {

    }
}


namespace R5T.Z0031.Raw
{
    [ValuesMarker]
    public partial interface ITypeNamedMethodNames : IValuesMarker
    {
        public ITypeNamedMethodName For_Method0001 => "R5T.F0007.IIndentationGenerator.ForClass".ToTypeNamedMethodName();
    }
}
