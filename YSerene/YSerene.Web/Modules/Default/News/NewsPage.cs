
namespace YSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/News"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.NewsRow))]
    public class NewsController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/News/NewsIndex.cshtml");
        }
    }
}