
using YSerene.Administration.Entities;

namespace YSerene.Default.Entities
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using Serenity.Data.Mapping;
    using System;
    using System.ComponentModel;
    using System.IO;

    [ConnectionKey("Default"), TableName("[dbo].[NewsCategory]")]
    [DisplayName("新闻分类"), InstanceName("分类"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    [LookupScript("Default.NewsCategory")]
    public sealed class NewsCategoryRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("分类ID"), Column("CategoryID"), Identity]
        public Int32? CategoryId
        {
            get { return Fields.CategoryId[this]; }
            set { Fields.CategoryId[this] = value; }
        }

        [DisplayName("分类名称"), Size(50), NotNull, QuickSearch]
        public String CategoryName
        {
            get { return Fields.CategoryName[this]; }
            set { Fields.CategoryName[this] = value; }
        }

        [DisplayName("描述"), Size(500)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.CategoryId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.CategoryName; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public NewsCategoryRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field CategoryId;
            public StringField CategoryName;
            public StringField Description;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.NewsCategory";
            }
        }
    }
}
