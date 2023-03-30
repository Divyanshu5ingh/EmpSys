using Acme.EmpSys.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Acme.EmpSys.Permissions;

public class EmpSysPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(EmpSysPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(EmpSysPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmpSysResource>(name);
    }
}
