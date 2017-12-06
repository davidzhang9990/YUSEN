
using YSerene.Administration.Entities;
using YSerene.Common;

namespace YSerene.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[EnList]")]
    [DisplayName("报名列表"), InstanceName("报名"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class EnListRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("En Id"), Identity]
        public Int64? EnId
        {
            get { return Fields.EnId[this]; }
            set { Fields.EnId[this] = value; }
        }

        [DisplayName("家长姓名"), Size(50), NotNull, QuickSearch]
        public String ParentName
        {
            get { return Fields.ParentName[this]; }
            set { Fields.ParentName[this] = value; }
        }

        [DisplayName("联系方式"), Size(11), NotNull, QuickSearch]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("小孩姓名"), Size(50), NotNull, QuickSearch]
        public String ChildName
        {
            get { return Fields.ChildName[this]; }
            set { Fields.ChildName[this] = value; }
        }

        [DisplayName("性别"), NotNull]
        public MemberSex? Sex
        {
            get { return (MemberSex?)Fields.Sex[this]; }
            set { Fields.Sex[this] = (Int16?)value; }
        }

        [DisplayName("出生日期"), NotNull]
        public DateTime? Birthday
        {
            get { return Fields.Birthday[this]; }
            set { Fields.Birthday[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.EnId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.ParentName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public EnListRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int64Field EnId;
            public StringField ParentName;
            public StringField Mobile;
            public StringField ChildName;
            public Int32Field Sex;
            public DateTimeField Birthday;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.EnList";
            }
        }
    }
}
