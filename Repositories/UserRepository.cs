using Microsoft.EntityFrameworkCore;
using OfficeHoursCalc.Context;
using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;

namespace OfficeHoursCalc.Repositories
{
    public class UserRepository : IRepository<User>
    {
        private readonly AppDbContext _dbContext;
        public UserRepository(AppDbContext appDbContext)
        {
            _dbContext = appDbContext;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _dbContext.Users.ToListAsync();
        }

        public async Task<User> GetById(int id)
        {
            return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        }
        public async Task Add(User user)
        {
            await _dbContext.AddAsync(user);
        }

        public void Update(User user)
        {
             _dbContext.Update(user);
        }

        public async Task Delete(int id)
        {
            var user = await GetById(id);
            _dbContext.Remove(user);
        }
    }
}
