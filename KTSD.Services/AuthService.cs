using System;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using KTSD.Core;
using KTSD.Core.Models;
using KTSD.Core.Services;
using Microsoft.IdentityModel.Tokens;

namespace KTSD.Services
{
    public class AuthService : IAuthService
    {
        // private readonly IUserService _userService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _uow;

        public AuthService(IMapper mapper, IUnitOfWork uow)
        {
            _mapper = mapper;
            _uow = uow;
        }

        public async Task<string> Login(string userName, string password, string secretKey)
        {
            var user = await _uow.Users.SingleOrDefaultAsync(f =>
                f.Email == userName); //await _userService.GetUserByEmail(userName);
            if (user == null) return null;
            if (user.Password != password) return null;

            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(secretKey);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[]
                {
                    new Claim("userId", user.Id.ToString()),
                    new Claim(ClaimTypes.Name, user.Name + " " + user.LastName)
                }),
                Expires = DateTime.UtcNow.AddMinutes(2),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);

            user.LastLoginTime = DateTime.Now;
            _uow.Users.Update(user);
            await _uow.SaveAsync();

            var generatedToken = tokenHandler.WriteToken(token);
            return generatedToken;
        }

        public async Task<UserInfoRes> GetUserInfoByToken(string token)
        {
            var handler = new JwtSecurityTokenHandler();
            var tokenS = handler.ReadToken(token) as JwtSecurityToken;
            var id = tokenS.Claims.First(claim => claim.Type == "userId").Value;
            var user = await _uow.Users.GetByIdAsync(int.Parse(id)); // _userService.GetUserById(int.Parse(id));
            var role = await _uow.Roles.GetByIdAsync(user.RoleId);
            user.Role = role;
            var result = _mapper.Map<UserInfoRes>(user);
            return result;
        }

        public async Task<ChangePasswordResponseModel> ChangePassword(ChangePasswordRequestModel model)
        {
            var user = await _uow.Users.SingleOrDefaultAsync(f => f.Email == model.Email);
            if (user == null)  return new ChangePasswordResponseModel { IsSuccess = false, Message = "Kullanıcı bulunamadı."};
            // if (user.Password != model.OldPassword) return new ChangePasswordResponseModel { IsSuccess = false, Message = "Mevcut şifre hatalı girildi."};
            user.Password = model.NewPassword;
            user.FirstLogin = true;
            _uow.Users.Update(user);
            await _uow.SaveAsync();
            return new ChangePasswordResponseModel { IsSuccess = true, Message = "Parola değiştirme işlemi başarılı."};
        }
    }
}