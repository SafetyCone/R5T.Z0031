using System;


namespace R5T.Z0031
{
    public class TypeNamedMethodNames : ITypeNamedMethodNames
    {
        #region Infrastructure

        public static ITypeNamedMethodNames Instance { get; } = new TypeNamedMethodNames();


        private TypeNamedMethodNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0031.Raw
{
    public class TypeNamedMethodNames : ITypeNamedMethodNames
    {
        #region Infrastructure

        public static ITypeNamedMethodNames Instance { get; } = new TypeNamedMethodNames();


        private TypeNamedMethodNames()
        {
        }

        #endregion
    }
}
