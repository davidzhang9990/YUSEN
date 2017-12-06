
using System.Collections.Generic;
using YSerene.Default.Entities;

namespace YSerene.Membership
{
    public class NewsListModel
    {
        public IEnumerable<NewsRow> NewsList { get; set; }
        public int PageCount { get; set; }
    }
}