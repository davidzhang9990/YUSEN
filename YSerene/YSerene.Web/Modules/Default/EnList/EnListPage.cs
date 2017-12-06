
namespace YSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/EnList"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.EnListRow))]
    public class EnListController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/EnList/EnListIndex.cshtml");
        }
    }
}