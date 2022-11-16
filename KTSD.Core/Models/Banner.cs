namespace KTSD.Core.Models
{
    public class Banner: BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string Path { get; set; }
        public string ButtonText { get; set; }
        public string ButtonLink { get; set; }
        public string LangCode { get; set; }
        public string OrderIndex { get; set; }
    }
}