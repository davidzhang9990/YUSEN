
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

    [ConnectionKey("Default"), TableName("[dbo].[News]")]
    [DisplayName("新闻列表"), InstanceName("新闻"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class NewsRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("News Id"), Column("NewsID"), Identity]
        public Int32? NewsId
        {
            get { return Fields.NewsId[this]; }
            set { Fields.NewsId[this] = value; }
        }

        [DisplayName("标题"), Size(100), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("图片"), Size(100), NotNull]
        public String Image
        {
            get { return Fields.Image[this]; }
            set { Fields.Image[this] = value; }
        }

        [DisplayName("分类"), Column("CategoryID"), NotNull, ForeignKey("[dbo].[NewsCategory]", "CategoryID"), LeftJoin("jCategory"), TextualField("CategoryCategoryName")]
        [LookupEditor(typeof(NewsCategoryRow),InplaceAdd = true)]
        public Int32? CategoryId
        {
            get { return Fields.CategoryId[this]; }
            set { Fields.CategoryId[this] = value; }
        }

        [DisplayName("信息来源"), Size(100), NotNull]
        public String SourceSite
        {
            get { return Fields.SourceSite[this]; }
            set { Fields.SourceSite[this] = value; }
        }

        [DisplayName("发布日期"), NotNull]
        public DateTime? CreateDate
        {
            get { return Fields.CreateDate[this]; }
            set { Fields.CreateDate[this] = value; }
        }

        [DisplayName("新闻详细")]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        [DisplayName("分类名称"), Expression("jCategory.[CategoryName]")]
        public String CategoryCategoryName
        {
            get { return Fields.CategoryCategoryName[this]; }
            set { Fields.CategoryCategoryName[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.NewsId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public NewsRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field NewsId;
            public StringField Title;
            public StringField Image;
            public Int32Field CategoryId;
            public StringField SourceSite;
            public DateTimeField CreateDate;
            public StringField Description;
            public StringField CategoryCategoryName;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.News";
            }
        }
    }
}
