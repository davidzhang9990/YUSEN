
namespace YSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.Pictures")]
    [BasedOnRow(typeof(Entities.PicturesRow))]
    public class PicturesColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int32 PictureId { get; set; }
        [EditLink]
        public String Title { get; set; }
        public String Description { get; set; }
    }
}