
namespace YSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.News")]
    [BasedOnRow(typeof(Entities.NewsRow))]
    public class NewsForm
    {
//        [Tab("新闻信息")]
//        [Category("输入项")]
        public String Title { get; set; }
        public Int32 CategoryId { get; set; }
        [DefaultValue("站内")]
        public String SourceSite { get; set; }
        [DefaultValue("now")]
        public DateTime CreateDate { get; set; }
        [ImageUploadEditor]
        public String Image { get; set; }
        [HtmlContentEditor(Cols = 20,Rows = 10)]
        public String Description { get; set; }
    }
}