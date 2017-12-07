
using System.Linq;
using System.Text;
using Serenity.Data;
using YSerene.Common;
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
        public ActionResult Features()
        {
            return View(MVC.Views.Membership.Web.Features);
        }

        [HttpGet]
        public ActionResult About()
        {
            return View(MVC.Views.Membership.Web.About);
        }

        [HttpGet]
        public ActionResult Parents()
        {
            return View(MVC.Views.Membership.Web.Parents);
        }

        [HttpGet]
        public ActionResult JoinUs()
        {
            return View(MVC.Views.Membership.Web.JoinUs);
        }

        [HttpGet]
        public ActionResult NewsList()
        {
            return View(MVC.Views.Membership.Web.NewsList);
        }

        [HttpGet]
        public ActionResult GetNewsQuery(int page = 0)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                page = page + 1;
                var pagesize = 6;
                //var cateList = uow.Connection.Query<NewsCategoryRow>("select * from NewsCategory");
                var newsList = uow.Connection.List<NewsRow>();
                var total = page * pagesize;

                var jsonData = new
                {
                    rows = newsList.Take(total).OrderBy(x => x.NewsId).ToList(),
                    total = newsList.Count,
                    page = page,
                    pagesize = pagesize
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

        [HttpGet]
        public ActionResult CreateJoinUs(string parentName, string mobile, string childName, int sex, string birthday)
        {
            using (var connection = SqlConnections.NewByKey("Default"))
            using (var uow = new UnitOfWork(connection))
            {
                connection.InsertAndGetID(new EnListRow
                {
                    ParentName = parentName,
                    Mobile = mobile,
                    ChildName = childName,
                    Sex = (MemberSex?)sex,
                    Birthday = Convert.ToDateTime(birthday),
                    InsertDate = DateTime.Now,
                    InsertUserId = 1
                });
                uow.Commit();
                return Content("ok");
            }
        }
    }
}