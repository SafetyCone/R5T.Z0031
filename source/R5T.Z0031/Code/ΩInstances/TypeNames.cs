using System;


namespace R5T.Z0031
{
    public class TypeNames : ITypeNames
    {
        #region Infrastructure

        public static ITypeNames Instance { get; } = new TypeNames();


        private TypeNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0031.Raw
{
    public class TypeNames : ITypeNames
    {
        #region Infrastructure

        public static ITypeNames Instance { get; } = new TypeNames();


        private TypeNames()
        {
        }

        #endregion
    }
}
