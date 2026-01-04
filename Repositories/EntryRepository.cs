using Microsoft.EntityFrameworkCore;
using OfficeHoursCalc.Context;
using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;

namespace OfficeHoursCalc.Repositories
{
    public class EntryRepository : IRepository<Entry>
    {
        private readonly AppDbContext _dbContext;
        public EntryRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<IEnumerable<Entry>> GetAll()
        {
            return await _dbContext.Entries.ToListAsync();
        }

        public async Task<Entry> GetById(int id)
        {
            return await _dbContext.Entries.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task Add(Entry entry)
        {
            await _dbContext.Entries.AddAsync(entry);
        }

        public void Update(Entry entry)
        {
            _dbContext.Entries.Update(entry);
        }

        public async Task Delete(int id)
        {
            var entry = await GetById(id);
            _dbContext.Entries.Remove(entry);
        }
    }
}
