using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IBlobService
    {
        Task<BlobInfo> GetBlobAsync(string name);
        Task<IEnumerable<string>> ListBlobsAsync();
        // Task UploadFileBlobAsync(string filePath, string fileName);
        Task UploadContentBlobAsync(string content, string fileName);
        Task UploadContentBlobFromStreamAsync(Stream stream, string fileName);
        Task DeleteBlobAsync(string blobName);
    }
}