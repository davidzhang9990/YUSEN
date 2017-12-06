
using System.Linq;
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
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                //var cateList = uow.Connection.Query<NewsCategoryRow>("select * from NewsCategory");
                var newsList = uow.Connection.List<NewsRow>();

                return View(MVC.Views.Membership.Web.NewsList, new NewsListModel()
                {
                    NewsList = newsList
                });
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