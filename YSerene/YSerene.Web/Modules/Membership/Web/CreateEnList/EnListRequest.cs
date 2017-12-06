namespace YSerene.Membership
{
    using Serenity.Services;
    using System;

    public class CreateEnListRequest : ServiceRequest
    {
        public String ParentName { get; set; }
        public String Mobile { get; set; }
        public String ChildName { get; set; }
        public Int32 Sex { get; set; }
        public DateTime Birthday { get; set; }
    }
}