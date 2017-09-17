﻿using Abp.Application.Navigation;
using Abp.Localization;
using NicVicABP.Authorization;

namespace NicVicABP.Web
{
    /// <summary>
    /// This class defines menus for the application.
    /// It uses ABP's menu system.
    /// When you add menu items here, they are automatically appear in angular application.
    /// See .cshtml and .js files under App/Main/views/layout/header to know how to render menu.
    /// </summary>
    public class NicVicABPNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            //context.Manager.MainMenu
            //    .AddItem(
            //        new MenuItemDefinition(
            //            "Home",
            //            new LocalizableString("HomePage", NicVicABPConsts.LocalizationSourceName),
            //            url: "#/",
            //            icon: "fa fa-home",
            //            requiresAuthentication: true
            //            )
            //    ).AddItem(
            //        new MenuItemDefinition(
            //            "Tenants",
            //            L("Tenants"),
            //            url: "#tenants",
            //            icon: "fa fa-globe",
            //            requiredPermissionName: PermissionNames.Pages_Tenants
            //            )
            //    ).AddItem(
            //        new MenuItemDefinition(
            //            "Users",
            //            L("Users"),
            //            url: "#users",
            //            icon: "fa fa-users",
            //            requiredPermissionName: PermissionNames.Pages_Users
            //            )
            //    ).AddItem(
            //        new MenuItemDefinition(
            //            "Roles",
            //            L("Roles"),
            //            url: "#users",
            //            icon: "fa fa-tag",
            //            requiredPermissionName: PermissionNames.Pages_Roles
            //        )
            //    )
            //    .AddItem(
            //        new MenuItemDefinition(
            //            "About",
            //            new LocalizableString("About", NicVicABPConsts.LocalizationSourceName),
            //            url: "#/about",
            //            icon: "fa fa-info"
            //            )
            //    );


            context.Manager.MainMenu
                .AddItem(
                    new MenuItemDefinition(
                        "TaskList",
                        new LocalizableString("TaskList", NicVicABPConsts.LocalizationSourceName),
                        url: "#/",
                        icon: "fa fa-tasks"
                        )
                ).AddItem(
                    new MenuItemDefinition(
                        "NewTask",
                        new LocalizableString("NewTask", NicVicABPConsts.LocalizationSourceName),
                        url: "#/new",
                        icon: "fa fa-asterisk"
                        )
                );
        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, NicVicABPConsts.LocalizationSourceName);
        }
    }
}
