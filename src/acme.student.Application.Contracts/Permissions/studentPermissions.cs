namespace acme.student.Permissions;

public static class studentPermissions
{
    public const string GroupName = "student";
    public const string GroupNameCommon = "Common";

    //Add your own permission names. Example:
    //public const string MyPermission1 = GroupName + ".MyPermission1";
    public class SinhVien
    {
        public const string Default = GroupNameCommon + ".SinhVien";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
    public class LopHoc
    {
        public const string Default = GroupNameCommon + ".LopHoc";
        public const string Update = Default + ".Update";
        public const string Create = Default + ".Create";
        public const string Delete = Default + ".Delete";
    }
}
