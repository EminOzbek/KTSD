using System.Collections.Generic;

namespace KTSD.Core.Models
{
    public class UserFile
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int FileId { get; set; }
        public File File { get; set; }
    }
    
    public class UserFileRequest
    {
        public List<int> Members { get; set; }
        public List<int> Workgroups { get; set; }
        public List<int> Users { get; set; }
        public int FolderId { get; set; }
    }
}