using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Claims;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/announcements")]
    public class AnnouncementController : ControllerBase
    {
        private readonly IAnnouncementService _announcementService;

        public AnnouncementController(IAnnouncementService announcementService)
        {
            _announcementService = announcementService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            // var user = HttpContext.User.GetId<int>();//HttpContext.User;

            var list = await _announcementService.GetAll();
            var response = new ServiceResponse<IEnumerable<Announcement>>
            {
                Data = list,
                Success = true,
                Message = ""
            };
            return Ok(response);
        }
        
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _announcementService.GetById(id));
        }


        [HttpPost]
        public async Task<IActionResult> Post(Announcement announcement)
        {
            try
            {
                await _announcementService.Create(announcement);
                return Ok();
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
                
        [HttpPut]
        public async Task<IActionResult> Put(Announcement announcement)
        {
            try
            {
                await _announcementService.Update(announcement);
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
                await _announcementService.Delete(id);
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
    
    // public static class ClaimsPrincipalExtensions
    // {
    //     public static TId GetId<TId>(this ClaimsPrincipal principal)
    //     {
    //         if (principal == null || principal.Identity == null || 
    //             !principal.Identity.IsAuthenticated)
    //         {
    //             throw new ArgumentNullException(nameof(principal));
    //         }
    //
    //         var loggedInUserId = principal.FindFirstValue(ClaimTypes.NameIdentifier);
    //
    //         if (typeof(TId) == typeof(string) || 
    //             typeof(TId) == typeof(int) || 
    //             typeof(TId) == typeof(long) || 
    //             typeof(TId) == typeof(Guid))
    //         {
    //             var converter = TypeDescriptor.GetConverter(typeof(TId));
    //
    //             return (TId)converter.ConvertFromInvariantString(loggedInUserId);
    //         }
    //
    //         throw new InvalidOperationException("The user id type is invalid.");
    //     }
    //
    //     public static Guid GetId(this ClaimsPrincipal principal)
    //     {
    //         return principal.GetId<Guid>();
    //     }
    // }

}