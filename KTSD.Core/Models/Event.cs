using System;
using System.ComponentModel;

namespace KTSD.Core.Models
{
    public class Event : BaseEntity
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndTime { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }
        public int Status { get; set; }
    }
}