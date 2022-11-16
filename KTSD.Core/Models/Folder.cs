using System.Collections.Generic;

namespace KTSD.Core.Models
{
    public class Folder : BaseEntity
    {
        public string Name { get; set; }
        public int ParentId { get; set; }
        public int OrderIndex { get; set; }
        public ICollection<File> Files { get; set; }
        public ICollection<UserFolder> UserFolders { get; set; }
    }

    public class FolderCreateReq
    {
        public string Name { get; set; }
        public int? ParentId { get; set; }
    }

    public class FolderListRes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public string ParentName { get; set; }
        public IEnumerable<FolderListRes> Children { get; set; }
    }
}