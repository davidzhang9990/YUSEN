
using System.ComponentModel;
using YSerene.Default;

namespace YSerene.Common
{
    using Serenity.ComponentModel;
    using System;

    [EnumKey("Default.Sex")]
    public enum MemberSex
    {
        [Description("男")]
        Boy = 0,
        [Description("女")]
        Girl = 1
    }
}
