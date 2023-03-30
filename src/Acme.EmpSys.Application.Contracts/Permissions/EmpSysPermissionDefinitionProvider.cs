using Acme.EmpSys.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;
using Volo.Abp.MultiTenancy;

namespace Acme.EmpSys.Permissions;

public class EmpSysPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var empSysGroup = context.AddGroup(EmpSysPermissions.GroupName, L("Permission:EmpSys"));

        empSysGroup.AddPermission(EmpSysPermissions.Dashboard.Host, L("Permission:Dashboard"), MultiTenancySides.Host);
        empSysGroup.AddPermission(EmpSysPermissions.Dashboard.Tenant, L("Permission:Dashboard"), MultiTenancySides.Tenant);

        var employeesPermission = empSysGroup.AddPermission(EmpSysPermissions.Employees.Default, L("Permission:Employees"));
        employeesPermission.AddChild(EmpSysPermissions.Employees.Create, L("Permission:Employees.Create"));
        employeesPermission.AddChild(EmpSysPermissions.Employees.Edit, L("Permission:Employees.Edit"));
        employeesPermission.AddChild(EmpSysPermissions.Employees.Delete, L("Permission:Employees.Delete"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<EmpSysResource>(name);
    }
}
