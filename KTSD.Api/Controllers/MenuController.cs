using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/menu")]
    public class MenuController : ControllerBase
    {
        private readonly IMenuService _menuService;

        public MenuController(IMenuService menuService)
        {
            _menuService = menuService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var menuList = await _menuService.GetAll();
            var response = new ServiceResponse<IEnumerable<NavMenu>>
            {
                Data = menuList,
                Success = true,
                Message = ""
            };

            return Ok(response);
        }

        [HttpGet("getMenus")]
        public async Task<IActionResult> GetMenus()
        {
            var menuList = _menuService.GetMenusWithChildren();
            var response = new ServiceResponse<IEnumerable<NavMenuListRes>>
            {
                Data = menuList,
                Success = true,
                Message = ""
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _menuService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(NavMenu menu)
        {
            try
            {
                await _menuService.Create(menu);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(NavMenu menu)
        {
            try
            {
                await _menuService.Update(menu);
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
                await _menuService.Delete(id);
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