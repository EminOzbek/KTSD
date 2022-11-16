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
    [Route("api/v1/settings")]
    public class SettingsController : ControllerBase
    {
        private readonly ISettingsService _settingsService;

        public SettingsController(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var settingList = await _settingsService.GetAll();
            var response = new ServiceResponse<IEnumerable<Settings>>
            {
                Data = settingList,
                Success = true,
                Message = ""
            };
            return Ok(response);
        }

        // [HttpGet("{id}")]
        // public async Task<IActionResult> GetById(int id)
        // {
        //     return Ok(await _settingsService.GetById(id));
        // }
        
        [HttpGet("{langCode}")]
        public async Task<IActionResult> GetByLangCode(string langCode)
        {
            return Ok(await _settingsService.GetByLangCode(langCode));
        }


        [HttpPost]
        public async Task<IActionResult> Post(Settings item)
        {
            try
            {
                await _settingsService.Create(item);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        
        [HttpPut]
        public async Task<IActionResult> Put(Settings item)
        {
            try
            {
                await _settingsService.Update(item);
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
                await _settingsService.Delete(id);
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