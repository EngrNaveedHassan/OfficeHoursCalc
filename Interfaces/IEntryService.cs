using OfficeHoursCalc.Entities;

namespace OfficeHoursCalc.Interfaces
{
    public interface IEntryService
    {
        Task<Entry?> GetByIdAsync(int entryId);
        Task<IEnumerable<Entry>> GetAllAsync();
        IEnumerable<Entry> GetAllByUserId(int userId);
        Task AddAsync(Entry entry);
    }
}
