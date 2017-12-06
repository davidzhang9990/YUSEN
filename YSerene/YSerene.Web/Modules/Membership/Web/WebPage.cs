
namespace YSerene.Membership.Pages
{
    using Serenity;
    using Serenity.Services;
    using System;
    using System.Web.Mvc;
    using System.Web.Security;

    [RoutePrefix(""), Route("{action=index}")]
    public partial class WebController : Controller
    {
        [HttpGet]
        public ActionResult Index(string activated)
        {
            return View(MVC.Views.Membership.Web.Index);
        }
    }
}