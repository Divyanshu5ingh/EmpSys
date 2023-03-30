using System.Threading.Tasks;
using Acme.EmpSys.Localization;
using Acme.EmpSys.MultiTenancy;
using Acme.EmpSys.Permissions;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace Acme.EmpSys.Web.Menus;

public class EmpSysMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<EmpSysResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                EmpSysMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(
    new ApplicationMenuItem(
        "EmpSys",
        l["Menu:EmpSys"],
        icon: "fa fa-employee"
    ).AddItem(
        new ApplicationMenuItem(
            "EmpSys.Employees",
            l["Menu:Employees"],
            url: "/Employees"
        ).RequirePermissions(EmpSysPermissions.Employees.Default) // Check the permission!
    ).AddItem( // ADDED THE NEW "AUTHORS" MENU ITEM UNDER THE "BOOK STORE" MENU
        new ApplicationMenuItem(
            "EmpSys.Departments",
            l["Menu:Departments"],
            url: "/Departments"
        ).RequirePermissions(EmpSysPermissions.Departments.Default)
    )
);


        if (MultiTenancyConsts.IsEnabled)
        {
            administration.SetSubItemOrder(TenantManagementMenuNames.GroupName, 1);
        }
        else
        {
            administration.TryRemoveMenuItem(TenantManagementMenuNames.GroupName);
        }

        administration.SetSubItemOrder(IdentityMenuNames.GroupName, 2);
        administration.SetSubItemOrder(SettingManagementMenuNames.GroupName, 3);

        return Task.CompletedTask;
    }
}
