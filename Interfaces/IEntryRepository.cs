using Microsoft.EntityFrameworkCore.Storage;
using OfficeHoursCalc.Entities;

namespace OfficeHoursCalc.Interfaces
{
    public interface IEntryRepository
    {
        Task<Entry?> GetByIdAsync(int entryId);
        Task<IEnumerable<Entry>> GetAllAsync();
        IQueryable<Entry> GetAllByUserId(int userId);
        Task AddAsync(Entry entry);
    }
}
