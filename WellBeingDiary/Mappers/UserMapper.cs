/*using Microsoft.CodeAnalysis.CSharp.Syntax;
using NuGet.Protocol;
using WellBeingDiary.Dtos.Account;
using WellBeingDiary.Entities;
using WellBeingDiary.Interfaces;

namespace WellBeingDiary.Mappers
{
    public class UserMapper
    {
        private readonly ITokenService _tokenService;
        public UserMapper(ITokenService tokenService)
        {
            _tokenService = tokenService;
        }
        public static NewUserDto ToNewUserDto(this AppUser user)
        {
            return new NewUserDto
            {
                UserName = user.UserName,
                Email = user.Email,
                Token = _tokenService.CreateToken(user)
            };
        }
    }
}
*/