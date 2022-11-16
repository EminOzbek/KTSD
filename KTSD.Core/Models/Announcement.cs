using System;

namespace KTSD.Core.Models
{
    public class Announcement : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Thumbnail { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
        public string LangCode { get; set; }

    }
}