
namespace YSerene.Default.Pages
{
    using Serenity;
    using Serenity.Web;
    using System.Web.Mvc;

    [RoutePrefix("Default/Pictures"), Route("{action=index}")]
    [PageAuthorize(typeof(Entities.PicturesRow))]
    public class PicturesController : Controller
    {
        public ActionResult Index()
        {
            return View("~/Modules/Default/Pictures/PicturesIndex.cshtml");
        }
    }
}