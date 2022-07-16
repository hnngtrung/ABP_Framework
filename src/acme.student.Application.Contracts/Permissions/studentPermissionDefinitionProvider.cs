using acme.student.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace acme.student.Permissions;

public class studentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(studentPermissions.GroupName);
        var myGroupCommon = context.AddGroup(studentPermissions.GroupNameCommon, L("Permission:Common"));

        var sinhVienPermission = myGroupCommon.AddPermission(studentPermissions.SinhVien.Default);
        sinhVienPermission.AddChild(studentPermissions.SinhVien.Update, L("Permission:Update"));
        sinhVienPermission.AddChild(studentPermissions.SinhVien.Create, L("Permission:Create"));
        sinhVienPermission.AddChild(studentPermissions.SinhVien.Delete, L("Permission:Delete"));

        var LopHocPermission = myGroupCommon.AddPermission(studentPermissions.LopHoc.Default);
        LopHocPermission.AddChild(studentPermissions.LopHoc.Update, L("Permission:Update"));
        LopHocPermission.AddChild(studentPermissions.LopHoc.Create, L("Permission:Create"));
        LopHocPermission.AddChild(studentPermissions.LopHoc.Delete, L("Permission:Delete"));

    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<studentResource>(name);
    }
}
