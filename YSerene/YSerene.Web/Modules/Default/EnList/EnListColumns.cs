
namespace YSerene.Default.Columns
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [ColumnsScript("Default.EnList")]
    [BasedOnRow(typeof(Entities.EnListRow))]
    public class EnListColumns
    {
        [EditLink, DisplayName("Db.Shared.RecordId"), AlignRight]
        public Int64 EnId { get; set; }
        [EditLink]
        public String ParentName { get; set; }
        public String Mobile { get; set; }
        public String ChildName { get; set; }
        [QuickFilter()]
        public Int32 Sex { get; set; }
        public DateTime Birthday { get; set; }
    }
}