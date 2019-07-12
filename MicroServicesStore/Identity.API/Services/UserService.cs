using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Identity.API.Models;
using Identity.API.ViewModels;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;

namespace Identity.API.Services
{
    public class UserService : IUserService
    {
        private List<User> _users = new List<User>
        {
            new User { FullName = "Tony Stark", Username = "ironman", Password = "admin@123" },
            new User { FullName = "Steve Rogers", Username = "capitain", Password = "pass@123" },
            new User { FullName = "Natasha Romanova", Username = "blackwidow", Password = "test@123" },
        };

        private readonly AppSettings _appSettings;

        public UserService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        public SecurityTokenViewModel Authenticate(LoginViewModel loginViewModel)
        {
            var user = _users.SingleOrDefault(x => x.Username == loginViewModel.UserName && x.Password == loginViewModel.Password);

            // return null if user not found
            if (user == null)
                return null;

            // authentication successful so generate jwt token
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.SecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[]
                {
                    new Claim("name", user.FullName)
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var jwtSecurityToken = tokenHandler.WriteToken(token);

            return new SecurityTokenViewModel(jwtSecurityToken);
        }
    }
}
