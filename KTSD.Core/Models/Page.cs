namespace KTSD.Core.Models
{
    public class Page : BaseEntity
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Keywords { get; set; }
        public string Slug { get; set; }
        public string Content { get; set; }
        public int Status { get; set; }

        public string LangCode { get; set; }
        // public int MenuId { get; set; }
        // public Menu Menu { get; set; }
    }

    public class PageListRes : BaseEntity
    {
        public string Title { get; set; }
        public string Slug { get; set; }
        public int Status { get; set; }
        public string MenuTitle { get; set; }
    } 
}