
namespace YSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.News")]
    [BasedOnRow(typeof(Entities.NewsRow))]
    public class NewsColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 NewsId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String CategoryCategoryName { get; set; }
        public String SourceSite { get; set; }
        public DateTime CreateDate { get; set; }
    }
}