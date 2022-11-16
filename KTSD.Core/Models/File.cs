using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace KTSD.Core.Models
{
    public class File : BaseEntity
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int FolderId { get; set; }
        public Folder Folder { get; set; }
        public ICollection<UserFile> UserFiles { get; set; }
    }

    public class FileCreateReq
    {
        public string Name { get; set; }
        public string Size { get; set; }
        public int FolderId { get; set; }
    }

    public class ReadMediaReponseModel
    {
        public string Name { get; set; }
        public string Type { get; set; }
    }
}