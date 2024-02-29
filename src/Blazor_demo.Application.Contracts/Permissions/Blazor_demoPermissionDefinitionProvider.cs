using Blazor_demo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Blazor_demo.Permissions;

public class Blazor_demoPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Blazor_demoPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Blazor_demoPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Blazor_demoResource>(name);
    }
}
