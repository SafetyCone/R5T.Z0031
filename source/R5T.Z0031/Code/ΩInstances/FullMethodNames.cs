using System;


namespace R5T.Z0031
{
    public class FullMethodNames : IFullMethodNames
    {
        #region Infrastructure

        public static IFullMethodNames Instance { get; } = new FullMethodNames();


        private FullMethodNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0031.Raw
{
    public class FullMethodNames : IFullMethodNames
    {
        #region Infrastructure

        public static IFullMethodNames Instance { get; } = new FullMethodNames();


        private FullMethodNames()
        {
        }

        #endregion
    }
}
