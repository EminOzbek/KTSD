using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KTSD.Core.Models;
using KTSD.Core.Services;
// using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Text;

namespace KTSD.Api.Controllers
{
    [ApiController]
    // [Authorize]
    [Route("api/v1/user")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var userList = await _userService.GetAllWithRole();
            var response = new ServiceResponse<IEnumerable<UserListRes>>
            {
                Data = userList,
                Success = true,
                Message = ""
            };
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userService.GetUserByIdWithWorkgroups(id));
        }
        
        [HttpPost("get-member-and-workgroup-id")]
        public async Task<IActionResult> GetMembersAndWorkGroupsById(List<int> ids)
        {
            try
            {
                var userList = await _userService.GetMembersAndWorkGroupsById(ids);
                var response = new {
                    Data = userList.Select(s => new
                    {
                        s.MemberId,
                    }),
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


        [HttpPost("forgot-password")]
        public async Task<IActionResult> Post(string email)
        {
            // var password = "123456";
            try
            {
                var user = await _userService.GetUserByEmail(email);
                if (user != null)
                {
                user.FirstLogin = false;
                await _userService.UpdateUser(user);
                // String emailAdress = "info@ktsd.org.tr";
                // String password = "s3xZWGVS";
                String emailAdress = "info@ktsd.org.tr";
                String password = "s3xZWGVS";
                // String subject = "KTSD parola değiştirme";
                // String body = "Parola değiştirme linkiniz başarıyla oluşturuldu!";
                // MailMessage msg = new MailMessage(emailAdress,email,subject,body);
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("info@ktsd.org.tr");
                mailMessage.To.Add(new MailAddress(email));
                mailMessage.Subject = "KTSD parola değiştirme";
                mailMessage.IsBodyHtml = true;
                mailMessage.Body = "Parola değiştirme linkiniz başarıyla oluşturuldu! \n\n <a href=\"http://www.ktsd.org.tr/admin/account/changePassword\"> Şifrenizi değiştirmek için lütfen tıklayınız.</a>";
                // sb.AppendLine("Name: ");  
                // sb.AppendLine("Mobile Number: ");  
                // sb.AppendLine("Email:");  
                // sb.AppendLine("Drop Downlist Name:");  
                // Attachment attach = new Attachment(Server.MapPath("folder/" + ImgName));  
                // msg.Attachments.Add(attach);  
                SmtpClient SmtpClient = new SmtpClient();
                SmtpClient.Credentials = new System.Net.NetworkCredential(emailAdress, password);
                SmtpClient.Host = "smtp.office365.com";
                SmtpClient.Port = 587;
                SmtpClient.EnableSsl = true;
                SmtpClient.Send(mailMessage);
                return Ok();
                }
                return BadRequest(new ServiceResponse<int>
                 {
                     Success = false,
                     Message = email
                 });
                // var user = await _userService.GetUserByEmail(email);
                // if (user != null)
                // {
                //     user.Password = "123456";
                //     user.FirstLogin = false;
                //     await _userService.UpdateUser(user);
                //     return Ok(password);
                // }
                // return BadRequest(new ServiceResponse<int>
                // {
                //     Success = false,
                //     Message = email
                // });
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


        [HttpPost]
        public async Task<IActionResult> Post(UserCreateReq user)
        {
            try
            {
                await _userService.CreateUser(user);
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

        [HttpPut]
        public async Task<IActionResult> Put(UserUpdateReq user)
        {
            try
            {
                await _userService.UpdateUser(user);
                var userWorkGroups = user.WorkgroupIds.Select(item => new UserWorkGroup()
                {
                    UserId = user.Id,
                    WorkGroupId = item
                });
                await _userService.UpdateUserWorkGroup(userWorkGroups,user.Id, null);
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
                await _userService.DeleteUser(id);
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

    public class ServiceResponse<T>
    {
        public T Data { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}