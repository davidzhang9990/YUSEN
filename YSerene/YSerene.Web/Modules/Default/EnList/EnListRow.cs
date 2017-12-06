
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
    [DisplayName("En List"), InstanceName("En List"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class EnListRow : Row, IIdRow, INameRow
    {
        [DisplayName("En Id"), Identity]
        public Int64? EnId
        {
            get { return Fields.EnId[this]; }
            set { Fields.EnId[this] = value; }
        }

        [DisplayName("Parent Name"), Size(50), NotNull, QuickSearch]
        public String ParentName
        {
            get { return Fields.ParentName[this]; }
            set { Fields.ParentName[this] = value; }
        }

        [DisplayName("Mobile"), Size(11), NotNull]
        public String Mobile
        {
            get { return Fields.Mobile[this]; }
            set { Fields.Mobile[this] = value; }
        }

        [DisplayName("Child Name"), Size(50), NotNull]
        public String ChildName
        {
            get { return Fields.ChildName[this]; }
            set { Fields.ChildName[this] = value; }
        }

        [DisplayName("Sex"), NotNull]
        public Int32? Sex
        {
            get { return Fields.Sex[this]; }
            set { Fields.Sex[this] = value; }
        }

        [DisplayName("Birthday"), NotNull]
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

        public class RowFields : RowFieldsBase
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
