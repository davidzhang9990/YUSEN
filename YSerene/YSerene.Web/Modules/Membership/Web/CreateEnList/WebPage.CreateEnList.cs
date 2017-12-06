
using System.IO;
using System.Web;
using Serenity.Data;
using Serenity.Web;
using YSerene.Administration;
using YSerene.Administration.Entities;
using YSerene.Administration.Repositories;
using YSerene.Common;
using YSerene.Default.Entities;

namespace YSerene.Membership.Pages
{
    using Serenity;
    using Serenity.Services;
    using System;
    using System.Web.Mvc;
    using System.Web.Security;

    public partial class WebController : Controller
    {
        [HttpGet]
        public ActionResult CreateEnList()
        {
            return View(MVC.Views.Membership.Web.CreateEnList.CreateEnList_);
        }

        [HttpPost, JsonFilter]
        public Result<ServiceResponse> CreateEnList(CreateEnListRequest request)
        {
            return this.UseConnection("Default", connection =>
            {
                request.CheckNotNull();
                Check.NotNullOrWhiteSpace(request.ParentName, "请输入家长姓名！");
                Check.NotNullOrWhiteSpace(request.Mobile, "请输入联系方式！");
                Check.NotNullOrWhiteSpace(request.ChildName, "请输入小孩姓名！");

                //                if (connection.Exists<UserRow>(
                //                        UserRow.Fields.Username == request.Email |
                //                        UserRow.Fields.Email == request.Email))
                //                {
                //                    throw new ValidationError("EmailInUse", Texts.Validation.EmailInUse);
                //                }

                using (var uow = new UnitOfWork(connection))
                {
                    var parentName = request.ParentName.TrimToEmpty();
                    var mobile = request.Mobile.TrimToEmpty();
                    var childName = request.ChildName.TrimToEmpty();
                    var sex = request.Sex;
                    var birthday = request.Birthday;

                    connection.InsertAndGetID(new EnListRow
                    {
                        ParentName = parentName,
                        Mobile = mobile,
                        ChildName = childName,
                        Sex = (MemberSex?)sex,
                        Birthday = birthday,
                        InsertDate = DateTime.Now,
                        InsertUserId = 1
                    });
                    uow.Commit();
                    return new ServiceResponse();
                }
            });
        }
    }
}