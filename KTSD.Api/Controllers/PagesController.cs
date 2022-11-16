using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/pages")]
    public class PagesController : ControllerBase
    {
        private readonly IPageService _pageService;
        private readonly IMapper _mapper;

        public PagesController(IPageService pageService, IMapper mapper)
        {
            _pageService = pageService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var pageList = await _pageService.GetPagesWithoutContent();
            var response = new ServiceResponse<IEnumerable<PageListRes>>
            {
                Data = pageList,
                Success = true,
                Message = ""
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _pageService.GetById(id));
        }

        [HttpGet("getBySlug/{slug}")]
        public async Task<IActionResult> GetBySlug(string slug)
        {
            return Ok(await _pageService.GetPageBySlug(slug));
        }

        [HttpPost]
        public async Task<IActionResult> Post(Page page)
        {
            try
            {
                await _pageService.Create(page);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Page page)
        {
            try
            {
                await _pageService.Update(page);
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
                await _pageService.Delete(id);
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