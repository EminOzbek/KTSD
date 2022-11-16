using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/workgroup")]
    public class WorkGroupController : ControllerBase
    {
        private readonly IWorkGroupService _workGroupService;
        private readonly IUserService _userService;

        public WorkGroupController(IWorkGroupService workGroupService, IUserService userService)
        {
            _workGroupService = workGroupService;
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var workGroupList = await _workGroupService.GetAll();
            var response = new ServiceResponse<IEnumerable<WorkGroup>>
            {
                Data = workGroupList,
                Success = true,
                Message = ""
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _workGroupService.GetWorkGroupByIdWithUsers(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(WorkGroup workGroup)
        {
            try
            {
                await _workGroupService.Create(workGroup);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(WorkgroupUpdateReq workGroup)
        {
            try
            {
                await _workGroupService.Update(workGroup);
                var userWorkGroups = workGroup.UserIds.Select(item => new UserWorkGroup()
                {
                    UserId = item,
                    WorkGroupId = workGroup.Id
                });
                await _userService.UpdateUserWorkGroup(userWorkGroups,null, workGroup.Id);
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
                await _workGroupService.Delete(id);
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
    }
}