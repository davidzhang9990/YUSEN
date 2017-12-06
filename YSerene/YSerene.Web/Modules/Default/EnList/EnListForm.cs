
namespace YSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.EnList")]
    [BasedOnRow(typeof(Entities.EnListRow))]
    public class EnListForm
    {
        public String ParentName { get; set; }
        public String Mobile { get; set; }
        public String ChildName { get; set; }
        public Int32 Sex { get; set; }
        public DateTime Birthday { get; set; }
    }
}