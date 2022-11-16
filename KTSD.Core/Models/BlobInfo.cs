using System.IO;

namespace KTSD.Core.Models
{
    public class BlobInfo
    {
        public BlobInfo(Stream content, string contentType)
        {
            Content = content;
            ContentType = contentType;
        }

        public Stream Content { get; private set; }
        public string ContentType { get; private set; }
    }
}