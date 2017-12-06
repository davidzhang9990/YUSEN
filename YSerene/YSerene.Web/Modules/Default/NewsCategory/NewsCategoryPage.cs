
namespace YSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/NewsCategory"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.NewsCategoryRow))]
    public class NewsCategoryController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/NewsCategory/NewsCategoryIndex.cshtml");
        }
    }
}