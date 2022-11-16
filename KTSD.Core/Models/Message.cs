using System;

namespace KTSD.Core.Models
{
    public class Message: BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string LangCode { get; set; }

    }
}