using System.Collections.Generic;

namespace KTSD.Core.Models
{
    public class NavMenu : BaseEntity
    {
        public string Name { get; set; }
        public string Slug { get; set; }
        public int Type { get; set; }
        public int Status { get; set; }
        public int? ParentID { get; set; }
        public string LangCode { get; set; }
        public int? OrderIndex { get; set; }    }

    public class NavMenuListRes : NavMenu
    {
        public IEnumerable<NavMenuListRes> Children { get; set; }
    }
}