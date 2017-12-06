
using OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup;

namespace YSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.NewsCategory")]
    [BasedOnRow(typeof(Entities.NewsCategoryRow))]
    public class NewsCategoryForm
    {
        public String CategoryName { get; set; }
        [TextAreaEditor(Rows = 5, Cols = 10)]
        public String Description { get; set; }
    }
}