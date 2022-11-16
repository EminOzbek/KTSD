using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KTSD.Core.Models
{
    public class WorkGroup: BaseEntity
    {
        public string Name { get; set; }
        public ICollection<UserWorkGroup> UserWorkGroups { get; set; }
    }

    public class WorkgroupUpdateReq : WorkGroup
    {
        public List<int> UserIds { get; set; }
    }
}