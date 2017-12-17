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

    [ConnectionKey("Default"), TableName("[dbo].[Pictures]")]
    [DisplayName("图库管理"), InstanceName("图册"), TwoLevelCached]
    [ReadPermission("Administration:General")]
    [ModifyPermission("Administration:General")]
    public sealed class PicturesRow : LoggingRow, IIdRow, INameRow
    {
        [DisplayName("Picture Id"), Column("PictureID"), Identity]
        public Int32? PictureId
        {
            get { return Fields.PictureId[this]; }
            set { Fields.PictureId[this] = value; }
        }

        [DisplayName("相册名"), Size(100), NotNull, QuickSearch]
        public String Title
        {
            get { return Fields.Title[this]; }
            set { Fields.Title[this] = value; }
        }

        [DisplayName("封面图"), Size(100), NotNull]
        public String KeyImage
        {
            get { return Fields.KeyImage[this]; }
            set { Fields.KeyImage[this] = value; }
        }

        [DisplayName("图片列表"), NotNull]
        public String ImageList
        {
            get { return Fields.ImageList[this]; }
            set { Fields.ImageList[this] = value; }
        }

        [DisplayName("描述"), Size(500)]
        public String Description
        {
            get { return Fields.Description[this]; }
            set { Fields.Description[this] = value; }
        }

        IIdField IIdRow.IdField
        {
            get { return Fields.PictureId; }
        }

        StringField INameRow.NameField
        {
            get { return Fields.Title; }
        }

        public static readonly RowFields Fields = new RowFields().Init();

        public PicturesRow()
            : base(Fields)
        {
        }

        public class RowFields : LoggingRowFields
        {
            public Int32Field PictureId;
            public StringField Title;
            public StringField KeyImage;
            public StringField ImageList;
            public StringField Description;

            public RowFields()
                : base()
            {
                LocalTextPrefix = "Default.Pictures";
            }
        }
    }
}
