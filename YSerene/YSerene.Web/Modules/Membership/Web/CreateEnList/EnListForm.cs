
using System.ComponentModel;
using YSerene.Common;
using YSerene.Default;

namespace YSerene.Membership
{
    using Serenity.ComponentModel;
    using System;

    [FormScript("Membership.CreateEnList")]
    public class EnListForm
    {
        [Required(true), Placeholder("家长姓名")]
        public String ParentName { get; set; }
        [Required(true), Placeholder("联系方式")]
        public String Mobile { get; set; }
        [Required(true), Placeholder("小孩姓名")]
        public String ChildName { get; set; }
        [RadioButtonEditor(typeof(MemberSex)),Required(true), Placeholder("性别"),DefaultValue(MemberSex.Boy)]
        public Int32 Sex { get; set; }
        [Required(true), Placeholder("出生日期")]
        public DateTime Birthday { get; set; }
    }
}
