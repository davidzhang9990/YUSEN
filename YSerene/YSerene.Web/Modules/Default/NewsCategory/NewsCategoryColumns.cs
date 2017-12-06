
namespace YSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.NewsCategory")]
    [BasedOnRow(typeof(Entities.NewsCategoryRow))]
    public class NewsCategoryColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 CategoryId { get; set; }
        [EditLink]
        public String CategoryName { get; set; }
        [Width(220)]
        public String Description { get; set; }
    }
}