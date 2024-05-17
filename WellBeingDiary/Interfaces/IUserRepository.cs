using WellBeingDiary.Entities;

namespace WellBeingDiary.Interfaces
{
    public interface IUserRepository
    {
        Task<List<AppUser>> GetAllAsync();
        Task<AppUser?> GetByIdAsync(string id);
        Task<AppUser?> DeleteAsync(string id);
        string? GetMyId();
        Task<AppUser?> GetMeAsync();
    }
}
