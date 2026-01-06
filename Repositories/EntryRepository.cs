using Microsoft.EntityFrameworkCore;
using OfficeHoursCalc.Context;
using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;

namespace OfficeHoursCalc.Repositories
{
    public class EntryRepository : IEntryRepository
    {
        private readonly AppDbContext _context;

        public EntryRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task AddAsync(Entry entry)
        {
            await _context.Entries.AddAsync(entry);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Entry>> GetAllAsync()
        {
            return await _context.Entries.ToListAsync();
        }

        public IQueryable<Entry> GetAllByUserId(int userId)
        {
            return _context.Entries.Where(e => e.UserId == userId);
        }

        public async Task<Entry?> GetByIdAsync(int entryId)
        {
            return await _context.Entries.FirstOrDefaultAsync(e => e.Id == entryId);
        }
    }
}
