using System.Collections.Generic;

namespace KTSD.Core.Models
{
    public class UserFolder
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int FolderId { get; set; }
        public Folder Folder { get; set; }
    }
    
    public class UserFolderRequest
    {
        public List<int> Members { get; set; }
        public List<int> Workgroups { get; set; }
        public List<int> Users { get; set; }
        public int FolderId { get; set; }
    }
}