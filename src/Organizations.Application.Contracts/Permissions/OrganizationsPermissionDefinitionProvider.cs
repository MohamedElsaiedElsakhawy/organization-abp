using Organizations.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Organizations.Permissions;

public class OrganizationsPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(OrganizationsPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(OrganizationsPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<OrganizationsResource>(name);
    }
}
