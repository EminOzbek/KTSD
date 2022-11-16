namespace KTSD.Core.Models
{
    public class Project : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public int Status { get; set; }
        public string LangCode { get; set; }

    }
}