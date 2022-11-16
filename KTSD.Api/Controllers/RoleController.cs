using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/roles")]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;

        public RoleController(IRoleService roleService)
        {
            _roleService = roleService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var roleList = await _roleService.GetAll();
            var response = new ServiceResponse<IEnumerable<Role>>
            {
                Data = roleList,
                Success = true,
                Message = ""
            };

            return Ok(response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _roleService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(Role role)
        {
            try
            {
                await _roleService.Create(role);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(Role role)
        {
            try
            {
                await _roleService.Update(role);
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
                await _roleService.Delete(id);
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