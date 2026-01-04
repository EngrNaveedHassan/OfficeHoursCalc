
using OfficeHoursCalc.Entities;

namespace OfficeHoursCalc.Interfaces
{
    public interface IRepository<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task Add(T user);
        public void Update(T user);
        public Task Delete(int id);
    }
}
