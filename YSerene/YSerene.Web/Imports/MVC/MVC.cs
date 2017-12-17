using System;

namespace MVC
{
    public static class Views
    {
        public static class Administration
        {
            public static class Language
            {
                public const string LanguageIndex = "~/Modules/Administration/Language/LanguageIndex.cshtml";
            }

            public static class Role
            {
                public const string RoleIndex = "~/Modules/Administration/Role/RoleIndex.cshtml";
            }

            public static class Translation
            {
                public const string TranslationIndex = "~/Modules/Administration/Translation/TranslationIndex.cshtml";
            }

            public static class User
            {
                public const string UserIndex = "~/Modules/Administration/User/UserIndex.cshtml";
            }

        }

        public static class Common
        {
            public static class Dashboard
            {
                public const string DashboardIndex = "~/Modules/Common/Dashboard/DashboardIndex.cshtml";
            }

            public static class Reporting
            {
                public const string ReportPage = "~/Modules/Common/Reporting/ReportPage.cshtml";
            }

        }

        public static class Default
        {
            public static class EnList
            {
                public const string EnListIndex = "~/Modules/Default/EnList/EnListIndex.cshtml";
            }

            public static class News
            {
                public const string NewsIndex = "~/Modules/Default/News/NewsIndex.cshtml";
            }

            public static class NewsCategory
            {
                public const string NewsCategoryIndex = "~/Modules/Default/NewsCategory/NewsCategoryIndex.cshtml";
            }

            public static class Pictures
            {
                public const string PicturesIndex = "~/Modules/Default/Pictures/PicturesIndex.cshtml";
            }
        }

        public static class Errors
        {
            public const string AccessDenied = "~/Views/Errors/AccessDenied.cshtml";
            public const string ValidationError = "~/Views/Errors/ValidationError.cshtml";
        }

        public static class Membership
        {
            public static class Account
            {
                public const string AccountLogin = "~/Modules/Membership/Account/AccountLogin.cshtml";
                public const string AccountLogin_AdminLTE = "~/Modules/Membership/Account/AccountLogin.AdminLTE.cshtml";
                public static class ChangePassword
                {
                    public const string AccountChangePassword = "~/Modules/Membership/Account/ChangePassword/AccountChangePassword.cshtml";
                }

                public static class ForgotPassword
                {
                    public const string AccountForgotPassword = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.cshtml";
                    public const string AccountForgotPassword_AdminLTE = "~/Modules/Membership/Account/ForgotPassword/AccountForgotPassword.AdminLTE.cshtml";
                }

                public static class ResetPassword
                {
                    public const string AccountResetPassword = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.cshtml";
                    public const string AccountResetPassword_AdminLTE = "~/Modules/Membership/Account/ResetPassword/AccountResetPassword.AdminLTE.cshtml";
                    public const string AccountResetPasswordEmail = "~/Modules/Membership/Account/ResetPassword/AccountResetPasswordEmail.cshtml";
                }

                public static class SignUp
                {
                    public const string AccountActivateEmail = "~/Modules/Membership/Account/SignUp/AccountActivateEmail.cshtml";
                    public const string AccountSignUp = "~/Modules/Membership/Account/SignUp/AccountSignUp.cshtml";
                    public const string AccountSignUp_AdminLTE = "~/Modules/Membership/Account/SignUp/AccountSignUp.AdminLTE.cshtml";
                }
            }

            public static class Web
            {
                public const string About = "~/Modules/Membership/Web/About.cshtml";
                public static class CreateEnList
                {
                    public const string CreateEnList_ = "~/Modules/Membership/Web/CreateEnList/CreateEnList.cshtml";
                }
                public const string Features  = "~/Modules/Membership/Web/Features .cshtml";
                public const string Index = "~/Modules/Membership/Web/Index.cshtml";
                public const string JoinUs = "~/Modules/Membership/Web/JoinUs.cshtml";
                public const string NewsDetail = "~/Modules/Membership/Web/NewsDetail.cshtml";
                public const string NewsList = "~/Modules/Membership/Web/NewsList.cshtml";
                public const string Parents = "~/Modules/Membership/Web/Parents.cshtml";
                public const string PictureDetail = "~/Modules/Membership/Web/PictureDetail.cshtml";
                public const string PictureList = "~/Modules/Membership/Web/PictureList.cshtml";
            }
        }

        public static class Shared
        {
            public const string _Layout = "~/Views/Shared/_Layout.cshtml";
            public const string _LayoutHead = "~/Views/Shared/_LayoutHead.cshtml";
            public const string _LayoutNoNavigation = "~/Views/Shared/_LayoutNoNavigation.cshtml";
            public const string _LayoutSlim = "~/Views/Shared/_LayoutSlim.cshtml";
            public const string _LayoutSlimHead = "~/Views/Shared/_LayoutSlimHead.cshtml";
            public const string _NewLayout = "~/Views/Shared/_NewLayout.cshtml";
            public const string Error = "~/Views/Shared/Error.cshtml";
            public const string LeftNavigation = "~/Views/Shared/LeftNavigation.cshtml";
        }
    }
}

