
using System.Linq;
using System.Text;
using Serenity.Data;
using YSerene.Default.Entities;

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
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                //var cateList = uow.Connection.Query<NewsCategoryRow>("select * from NewsCategory");
                var cateList = uow.Connection.List<NewsCategoryRow>();

                return View(MVC.Views.Membership.Web.Index, new NewsCategoryModel()
                {
                    NewsCategoryLists = cateList
                });
            }
        }

        [HttpGet]
        public ActionResult NewsList()
        {
            //            using (var connection = SqlConnections.NewByKey("Default"))
            //            using (var uow = new UnitOfWork(connection))
            //            {
            //                //var cateList = uow.Connection.Query<NewsCategoryRow>("select * from NewsCategory");
            //                var newsList = uow.Connection.List<NewsRow>();
            //                var total = page * 2;
            //
            //                if (total >= newsList.Count)
            //                {
            //                    page = -1;
            //                }
            //
            //                page = page + 1;
            //                return View(MVC.Views.Membership.Web.NewsList, new NewsListModel()
            //                {
            //                    NewsList = newsList.Take(total).OrderBy(x => x.NewsId),
            //                    PageCount = page
            //                });
            //            }
            return View(MVC.Views.Membership.Web.NewsList);
        }

        [HttpGet]
        public ActionResult GetNewsQuery(int page = 0)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                page = page + 1;
                //var cateList = uow.Connection.Query<NewsCategoryRow>("select * from NewsCategory");
                var newsList = uow.Connection.List<NewsRow>();
                var total = page * 2;

                var jsonData = new
                {
                    rows = newsList.Take(total).OrderBy(x => x.NewsId).ToList(),
                    total = newsList.Count,
                    page = page
                };

                return Content(jsonData.ToJson(), "application/Json", Encoding.UTF8);
            }
        }

        [HttpGet]
        public ActionResult NewsDetail(int cateId)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                //var cateList = uow.Connection.Query<NewsCategoryRow>("select * from NewsCategory");
                var caterow = uow.Connection.TryById<NewsRow>(cateId);

                return View(MVC.Views.Membership.Web.NewsDetail, caterow);
            }
        }
    }
}