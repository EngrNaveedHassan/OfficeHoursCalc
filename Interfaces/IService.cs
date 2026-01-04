
using OfficeHoursCalc.Entities;
using System.Threading.Tasks;

namespace OfficeHoursCalc.Interfaces
{
    public interface IService<T> where T : class
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<bool> Add(T user);
        public bool Update(T user);
        public Task<bool> Delete(int id);
    }
}
