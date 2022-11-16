using System;
using System.Threading.Tasks;
using KTSD.Api.Helpers;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace KTSD.Api.Controllers
{
    [ApiController]
    [AllowAnonymous]
    [Route("api/v1/auth")]
    public class AuthController : ControllerBase
    {
        private readonly IAuthService _authService;
        private readonly AppSettings _appSettings;

        public AuthController(IAuthService authService, IOptions<AppSettings> appSettings)
        {
            _authService = authService;
            _appSettings = appSettings.Value;
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login(AuthLoginReq authLoginReq)
        {
            try
            {
                var token = await _authService.Login(authLoginReq.userName, authLoginReq.password,
                    _appSettings.SecretKey);
                if (!string.IsNullOrEmpty(token))
                {
                    return Ok(new ServiceResponse<string>
                    {
                        Data = token,
                        Success = true,
                        Message = "Success"
                    });
                }
                else
                {
                    return Ok(new ServiceResponse<string>
                    {
                        Data = null,
                        Success = false,
                        Message = "LoginError"
                    });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new ServiceResponse<string>
                {
                    Data = null,
                    Success = false,
                    Message = e.Message
                });
            }
        }

        [HttpGet("me")]
        public async Task<IActionResult> UserInfo()
        {
            try
            {
                string authHeader = Request.Headers["Authorization"];
                if (string.IsNullOrEmpty(authHeader)) return Unauthorized();
                authHeader = authHeader.Replace("Bearer ", "");
                var user = await _authService.GetUserInfoByToken(authHeader);
                if (user != null)
                {
                    return Ok(new ServiceResponse<UserInfoRes>
                    {
                        Data = user,
                        Success = true,
                        Message = "Success"
                    });
                }

                return Unauthorized(new ServiceResponse<string>
                {
                    Data = null,
                    Success = false,
                    Message = "UserNotFound"
                });
            }
            catch (Exception e)
            {
                return BadRequest(new ServiceResponse<string>
                {
                    Data = null,
                    Success = false,
                    Message = e.Message
                });
            }
        }
        
        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordRequestModel model)
        {
            try
            {
                var result = await _authService.ChangePassword(model);
                if (result.IsSuccess)
                {
                    return Ok(new
                    {
                        Data = true,
                        Success = result.IsSuccess,
                        result.Message
                    });
                }
                else
                {
                    return StatusCode(400, new
                    {
                        Data = false,
                        Success = result.IsSuccess,
                        result.Message
                    });
                }
            }
            catch (Exception e)
            {
                return BadRequest(new ServiceResponse<string>
                {
                    Data = null,
                    Success = false,
                    Message = e.Message
                });
            }
        }
    }

    public class AuthLoginReq
    {
        public string userName { get; set; }
        public string password { get; set; }
    }
}