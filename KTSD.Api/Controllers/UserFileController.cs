using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Repository;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/user-file")]
    public class UserFileController : ControllerBase
    {
        private readonly IUserFolderService _userFolderService;

        public UserFileController(IUserFolderService userFolderService)
        {
            _userFolderService = userFolderService;
        }
        
        [HttpPost]
        public async Task<IActionResult> Post(UserFolderRequest model)
        {
            try
            {
                await _userFolderService.SetUserFileAccess(model);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
           
        }
        
        [HttpGet]
        public IActionResult Get(int userId)
        {
            try
            {
                var fileList =  _userFolderService.GetFilesByUserId(userId);
                var response = new ServiceResponse<IEnumerable<File>>
                {
                    Data = fileList,
                    Success = true,
                    Message = ""
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
           
        }
        [HttpGet("folders")]
        public IActionResult GetFolder(int userId)
        {
            try
            {
                var folderList =  _userFolderService.GetFoldersByUserId(userId);
                var response = new ServiceResponse<IEnumerable<FolderListRes>>
                {
                    Data = folderList,
                    Success = true,
                    Message = ""
                };
                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
           
        }
    }
}