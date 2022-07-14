using acme.student.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace acme.student.Permissions;

public class studentPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(studentPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(studentPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<studentResource>(name);
    }
}
