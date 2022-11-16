using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using File = KTSD.Core.Models.File;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/files")]
    public class FileController : ControllerBase
    {
        private readonly IFileService _fileService;


        public FileController(IFileService fileService)
        {
            _fileService = fileService;
        }

       // [HttpPost("file")]
        [HttpPost("file/{fileName}")]
        public async Task<IActionResult> DownloadFile(string fileName)
        {
            if (fileName == null)
                return Content("filename not present");
            
            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Files", fileName);
            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }

            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }
        
       [HttpGet("media/{fileName}")]
      
        public async Task<IActionResult> GetMedia(string fileName)
        {
            if (fileName == null)
                return Content("filename not present");

            var path = Path.Combine(
                Directory.GetCurrentDirectory(),
                "Media", fileName);

            var memory = new MemoryStream();
            using (var stream = new FileStream(path, FileMode.Open))
            {
                await stream.CopyToAsync(memory);
            }
            memory.Position = 0;
            return File(memory, GetContentType(path), Path.GetFileName(path));
        }
        
    
        [HttpGet("read-media")]
        public async Task<IActionResult> ReadMedia(string folderName)
        {     
            var files = await ReadFile(folderName);
            return Ok(files);
        }
        
        [HttpGet("read-media-files/{src}")]
        public IActionResult readMediasFiles(string src){
            var path = Path.Combine(Directory.GetCurrentDirectory(),"Media", src);
            var files = ReadMediasFiles(path);
            return Ok(files);
        }
    //  [HttpGet("last-files/{userId}/{size}")]
    //  public async Task<IActionResult> GetLastUploadFiles(int userId, string size)
    //  {
    //      var list = await _fileService.GetLastUploadedFiles(userId, size);
    //      var response = new ServiceResponse<IEnumerable<FileResponseModel>>
    //      {
    //          Data = list,
    //          Success = true,
    //          Message = ""
    //      };
    //      return Ok(response);
    //  }
         private string GetContentType(string path)
         {
             var types = GetMimeTypes();
             var ext = Path.GetExtension(path).ToLowerInvariant();
             return types[ext];
         }

        private Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }

        [HttpPost("upload")]
        public async Task<IActionResult> UploadFile(IFormFile file)
        {
            await WriteFile(file, "Files");
            return Ok();
        }

        [HttpPost("upload-media/{getPath}")]
        public async Task<IActionResult> UploadMedia(IFormFile file,string getPath)
        {
            await WriteFile(file, getPath.Replace("*","/"));
            return Ok();
        }

        [HttpPost("create-folder/{folderName}/{getPath}")]
        public IActionResult createFolder(string folderName,string getPath)
        {
           var path = Path.Combine(Directory.GetCurrentDirectory(),getPath.Replace("*","/"));
            DirectoryInfo f = new DirectoryInfo((path+ "/" + folderName));
            // var info = new DirectoryInfo(folderName);   
            if (f.Exists){
                return BadRequest("Already exists");
            }
            f.Create();
            return Ok(folderName + " Klasörü Oluşturuldu.");
            // var files = Directory.CreateDirectory(path + "/" + info);
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var list = await _fileService.GetAll();
            // var orderedList = list.OrderByDescending(p => p.CreatedAt).ToList();
            var response = new ServiceResponse<IEnumerable<File>>
            {
                Data = list.OrderByDescending(p => p.CreatedAt),
                Success = true,
                Message = ""
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _fileService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(FileCreateReq file)
        {
            try
            {
                await _fileService.Create(new File
                {
                    Name = file.Name,
                    Size = file.Size,
                    FolderId = file.FolderId,
                    CreatedAt = DateTime.Now
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }


        [HttpPut]
        public async Task<IActionResult> Put(File file)
        {
            try
            {
                await _fileService.Update(file);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(new ServiceResponse<int>
                {
                    Success = false,
                    Message = e.Message
                });
            }
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _fileService.Delete(id);
                var response = new ServiceResponse<int>
                {
                    Data = id,
                    Success = true,
                    Message = ""
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(new ServiceResponse<int>
                {
                    Success = false,
                    Message = e.Message
                });
            }
        }
//-----------------------------------
// public IActionResult createFolder(string folderName,string getPath)
//         {
//            var path = Path.Combine(Directory.GetCurrentDirectory(),getPath.Replace("*","/"));
//             DirectoryInfo f = new DirectoryInfo((path+ "/" + folderName));
//             // var info = new DirectoryInfo(folderName);   
//             if (f.Exists){
//                 return BadRequest("Already exists");
//             }
//             f.Create();
//             return Ok(folderName + " Klasörü Oluşturuldu.");
//             // var files = Directory.CreateDirectory(path + "/" + info);
//         }
//--------------

        [HttpDelete("remove-media/{name}/{getPath}/{type}")]
        public async Task<IActionResult> DeleteMedia(string name,string getPath,string type)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(),getPath);
            string newPath= path.Replace("*","/");
            string fullPath = $"{newPath}/{name}";
            if(type=="folder"){
              System.IO.Directory.Delete(fullPath);   
            }else{
               System.IO.File.Delete(fullPath);
            }
            try    
            {   
               var response = new ServiceResponse<string>
                {
                    Data = "deneme",
                    Success = true,
                    Message = ""
                };
                return Ok(response);

            }    
            catch (IOException e)    
            {    
                return BadRequest(new ServiceResponse<string>
                {
                    Success = false,
                    Message = e.Message
                });  
            } 
        }


        // [HttpDelete("remove-media/{id}")]
        // public async Task<IActionResult> Delete(int id)
        // {
        //     try
        //     {
        //         await _fileService.Delete(id);
        //         var response = new ServiceResponse<int>
        //         {
        //             Data = id,
        //             Success = true,
        //             Message = ""
        //         };
        //         return Ok(response);
        //     }
        //     catch (Exception e)
        //     { 
        //         return BadRequest(new ServiceResponse<int>
        //         {   
        //             Success = false,
        //             Message = e.Message
        //         });
                
        //     }
        // }

//----------------------------------
        private async Task<bool> WriteFile(IFormFile file, string folder)
        {
            var isSaveSuccess = false;
            try
            {
                var fileName = file.FileName;
                var path = Path.Combine(Directory.GetCurrentDirectory(), folder,
                    fileName);

                await using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }

                isSaveSuccess = true;
            }
            catch (Exception e)
            {
                //log error
            }

            return isSaveSuccess;
        }

        private async Task<List<ReadMediaReponseModel>> ReadFile(string folder)
        {
            var info = new DirectoryInfo(folder);
            var folders = info.GetDirectories().OrderByDescending(p => p.CreationTime).Select(f => new ReadMediaReponseModel { Name = f.Name, Type = "folder"}).ToList();
            var files = info.GetFiles().OrderByDescending(p => p.CreationTime).Select(f => new ReadMediaReponseModel { Name = f.Name, Type = "file"});
            folders.AddRange(files);
            return folders.ToList();
            // try
            // {
            //     foreach (string files in info.GetFiles().OrderByDescending(p => p.CreationTime).Select(f => new ReadMediaReponseModel { Name = f.Name, Type = "file"}).ToList())
            //         {
            //             return files.ToList() 
            //         }

            //     foreach (string folders in info.GetDirectories().OrderByDescending(p => p.CreationTime).Select(f => new ReadMediaReponseModel { Name = f.Name, Type = "folder"}).ToList())
            //         {
            //             await ReadFile(folders);
            //         }
            // }
            // catch (Exception e)
            // {
            //             //eröl
            // }

        }

        private List<string> ReadMediasFiles(string folder){
            // var info = new DirectoryInfo(file);
            var files = Directory.GetFiles(folder);
            return files.ToList();
        }
    }
}