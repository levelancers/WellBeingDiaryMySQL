using WellBeingDiary.Entities;

namespace WellBeingDiary.Interfaces
{
    public interface ITokenService
    {
        Task<string> CreateToken(AppUser user);
        Task<IEnumerable<string>> GetUserRoleAsync(string userName);
    }
}
