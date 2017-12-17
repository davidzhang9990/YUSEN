
namespace YSerene.Default.Forms
{
    using Serenity;
    using Serenity.ComponentModel;
    using Serenity.Data;
    using System;
    using System.ComponentModel;
    using System.Collections.Generic;
    using System.IO;

    [FormScript("Default.Pictures")]
    [BasedOnRow(typeof(Entities.PicturesRow))]
    public class PicturesForm
    {
        public String Title { get; set; }
        [ImageUploadEditor]
        public String KeyImage { get; set; }
        [MultipleImageUploadEditor]
        public String ImageList { get; set; }
        public String Description { get; set; }
    }
}