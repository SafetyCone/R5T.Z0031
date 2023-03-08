using System;


namespace R5T.Z0031
{
    public class KindMarkedFullMemberNames : IKindMarkedFullMemberNames
    {
        #region Infrastructure

        public static IKindMarkedFullMemberNames Instance { get; } = new KindMarkedFullMemberNames();


        private KindMarkedFullMemberNames()
        {
        }

        #endregion
    }
}


namespace R5T.Z0031.Raw
{
    public class KindMarkedFullMemberNames : IKindMarkedFullMemberNames
    {
        #region Infrastructure

        public static IKindMarkedFullMemberNames Instance { get; } = new KindMarkedFullMemberNames();


        private KindMarkedFullMemberNames()
        {
        }

        #endregion
    }
}
