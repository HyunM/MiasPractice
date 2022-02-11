using Mias.Practice.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mias.Practice.Permissions;

public class PracticePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(PracticePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PracticePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PracticeResource>(name);
    }
}
