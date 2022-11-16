using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    [Route("api/v1/member")]
    public class MemberController: ControllerBase
    {
        private readonly IMemberService _memberService;
        
        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var memberList = await _memberService.GetAll();
            var response = new ServiceResponse<IEnumerable<Member>>
            {
                Data = memberList,
                Success = true,
                Message = ""
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _memberService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(Member member)
        {
            try
            {
                await _memberService.Create(member);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Member member)
        {
            try
            {
                await _memberService.Update(member);
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
                await _memberService.Delete(id);
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