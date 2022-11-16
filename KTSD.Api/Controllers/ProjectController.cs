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
    [Route("api/v1/projects")]
    public class ProjectController : ControllerBase
    {
        private readonly IProjectService _projectService;

        public ProjectController(IProjectService projectService)
        {
            _projectService = projectService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var projectList = await _projectService.GetAll();
            var response = new ServiceResponse<IEnumerable<Project>>
            {
                Data = projectList,
                Success = true,
                Message = ""
            };

            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _projectService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(Project project)
        {
            try
            {
                await _projectService.Create(project);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }

        [HttpPut]
        public async Task<IActionResult> Put(Project project)
        {
            try
            {
                await _projectService.Update(project);
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
                await _projectService.Delete(id);
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