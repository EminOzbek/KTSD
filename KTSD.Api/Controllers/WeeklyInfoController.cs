using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;
namespace KTSD.Api.Controllers
{
   [ApiController]
    [Route("api/v1/weeklyInfo")]
    public class WeeklyInfoController: ControllerBase
    {
        private readonly IWeeklyInfoService _weeklyInfoService;
        
        public WeeklyInfoController(IWeeklyInfoService weeklyInfoService)
        {
            _weeklyInfoService = weeklyInfoService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var weeklyInfoList = await _weeklyInfoService.GetAll();
            var response = new ServiceResponse<IEnumerable<WeeklyInfo>>
            {
                Data = weeklyInfoList.OrderByDescending(p => p.CreatedAt),
                Success = true,
                Message = ""
            };

            return Ok(response);
        }
        

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _weeklyInfoService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(WeeklyInfo weeklyInfo)
        {
            try
            {
                await _weeklyInfoService.Create(weeklyInfo);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(WeeklyInfo weeklyInfo)
        {
            try
            {
                await _weeklyInfoService.Update(weeklyInfo);
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
                await _weeklyInfoService.Delete(id);
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