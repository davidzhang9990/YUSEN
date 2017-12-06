using Serenity.Navigation;
using Administration = YSerene.Administration.Pages;
using MyPages = YSerene.Default.Pages;

//[assembly: NavigationLink(1000, "Dashboard", url: "~/", permission: "", icon: "fa-tachometer")]

[assembly: NavigationMenu(2000, "报名管理", icon: "fa-file-text-o")]
[assembly: NavigationLink(2100, "报名管理/报名列表", typeof(MyPages.EnListController), icon: null)]

//[assembly: NavigationMenu(9000, "Administration", icon: "fa-desktop")]
//[assembly: NavigationLink(9000, "Administration/Exceptions Log", url: "~/errorlog.axd", permission: YSerene.Administration.PermissionKeys.Security, icon: "icon-ban", Target = "_blank")]
//[assembly: NavigationLink(9000, "Administration/Languages", typeof(Administration.LanguageController), icon: "fa-comments")]
//[assembly: NavigationLink(9000, "Administration/Translations", typeof(Administration.TranslationController), icon: "fa-comment-o")]
//[assembly: NavigationLink(9000, "Administration/Roles", typeof(Administration.RoleController), icon: "fa-lock")]
//[assembly: NavigationLink(9000, "Administration/User Management", typeof(Administration.UserController), icon: "fa-users")]