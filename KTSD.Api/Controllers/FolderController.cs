using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using KTSD.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/folders")]
    public class FolderController : ControllerBase
    {
        private readonly IFolderService _folderService;

        public FolderController(IFolderService folderService)
        {
            _folderService = folderService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var folderList = _folderService.GetAllWithChildren().ToList();
            var orderedFolderList = folderList.OrderBy(p => p.OrderIndex).ToList();
            var response = new ServiceResponse<IEnumerable<FolderListRes>>
            {
                Data = orderedFolderList,
                Success = true,
                Message = ""
            };
            return Ok(response);
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var folderList = await _folderService.GetAll();
            var response = new ServiceResponse<IEnumerable<Folder>>
            {
                Data = folderList.OrderBy(p => p.Name),
                Success = true,
                Message = ""
            };
            return Ok(response);
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _folderService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Post(FolderCreateReq item)
        {
            try
            {
                await _folderService.Create(new Folder
                {
                    Name = item.Name,
                    ParentId = item.ParentId ?? 0
                });
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Folder item)
        {
            try
            {
                await _folderService.Update(item);
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
                await _folderService.Delete(id);
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

        [HttpGet("{id}/files")]
        public async Task<IActionResult> GetByFolderId(int id)
        {
            return Ok(await _folderService.GetFolderWithFilesById(id));
        }
        
        [HttpPost("bulk-updates")]
        public async Task<IActionResult> BulkFolderUpdate(IEnumerable<Folder> folders)
        {
            try
            {
               _folderService.BulkFolderUpdate(folders);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
    }
}