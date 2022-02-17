using Mias.Practice.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Mias.Practice.Permissions;

public class PracticePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var practiceGroup = context.AddGroup(PracticePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(PracticePermissions.MyPermission1, L("Permission:MyPermission1"));

        var customersPermission = practiceGroup.AddPermission(
        PracticePermissions.Customers.Default, L("Permission:Customers"));

        customersPermission.AddChild(
            PracticePermissions.Customers.Create, L("Permission:Customers.Create"));

        customersPermission.AddChild(
            PracticePermissions.Customers.Edit, L("Permission:Customers.Edit"));

        customersPermission.AddChild(
            PracticePermissions.Customers.Delete, L("Permission:Customers.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<PracticeResource>(name);
    }
}
