using System.Threading.Tasks;
using acme.student.Localization;
using acme.student.MultiTenancy;
using acme.student.Permissions;
using Volo.Abp.Identity.Web.Navigation;
using Volo.Abp.SettingManagement.Web.Navigation;
using Volo.Abp.TenantManagement.Web.Navigation;
using Volo.Abp.UI.Navigation;

namespace acme.student.Web.Menus;

public class studentMenuContributor : IMenuContributor
{
    public async Task ConfigureMenuAsync(MenuConfigurationContext context)
    {
        if (context.Menu.Name == StandardMenus.Main)
        {
            await ConfigureMainMenuAsync(context);
        }
    }

    private async Task ConfigureMainMenuAsync(MenuConfigurationContext context)
    {
        var administration = context.Menu.GetAdministration();
        var l = context.GetLocalizer<studentResource>();

        context.Menu.Items.Insert(
            0,
            new ApplicationMenuItem(
                studentMenus.Home,
                l["Menu:Home"],
                "~/",
                icon: "fas fa-home",
                order: 0
            )
        );
        context.Menu.AddItem(new ApplicationMenuItem("TongQuan", "Tong Quan", icon: "fa fa-sign", order: 1));

        var lopHoc = await context.IsGrantedAsync(studentPermissions.LopHoc.Default);
        if(lopHoc)
        {
            context.Menu.AddItem(new ApplicationMenuItem("LopHoc", "Lop Hoc", icon: "fa fa-circle", order: 2, url: "/Commons/LopHoc"));
        }
        var sinhVien = await context.IsGrantedAsync(studentPermissions.SinhVien.Default);
        if (sinhVien)
        {
            context.Menu.AddItem(new ApplicationMenuItem("SinhVien", "Sinh Vien", icon: "fa fa-users", order: 3, url: "/Commons/SinhVien"));
        }

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
    }
}
