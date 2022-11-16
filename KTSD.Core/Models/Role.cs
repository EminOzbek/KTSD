using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace KTSD.Core.Models
{
    public class Role : BaseEntity
    {
        public Role()
        {
            Users = new Collection<User>();
        }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<User> Users { get; set; }

    }

    public class RoleRes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}