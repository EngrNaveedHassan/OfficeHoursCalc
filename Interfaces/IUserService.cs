using OfficeHoursCalc.Entities;

namespace OfficeHoursCalc.Interfaces
{
    public interface IUserService
    {
        Task<User> GetByIdAsync(int userId);
        Task<IEnumerable<User>> GetAllAsync();
        Task AddAsync(User user);
        Task UpdateAsync(User user);
        Task DeleteAsync(int userId);
        Task<User> GetCurrentUserAsync();
    }
}
