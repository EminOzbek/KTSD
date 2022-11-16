using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KTSD.Core.Models
{
    public class Member: BaseEntity
    {
        public Member()
        {
            Users = new Collection<User>();
        }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public ICollection<User> Users { get; set; }
    }

    public class MemberResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}