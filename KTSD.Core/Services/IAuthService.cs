using System;
using System.Threading.Tasks;
using KTSD.Core.Models;

namespace KTSD.Core.Services
{
    public interface IAuthService
    {
        Task<string> Login(string userName, string password, string secretKey);
        Task<UserInfoRes> GetUserInfoByToken(string token);
        Task<ChangePasswordResponseModel> ChangePassword(ChangePasswordRequestModel model);
    }
}