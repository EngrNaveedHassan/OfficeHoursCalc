using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;
using OfficeHoursCalc.Repositories;

namespace OfficeHoursCalc.Services
{
    public class EntryService : IService<Entry>
    {
        private readonly IRepository<Entry> _entryRepository;
        public EntryService(IRepository<Entry> entryRepository)
        {
            _entryRepository = entryRepository;
        }

        public async Task<IEnumerable<Entry>> GetAll()
        {
            try
            {
                return await _entryRepository.GetAll();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public async Task<Entry> GetById(int id)
        {
            try
            {
                return await _entryRepository.GetById(id);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public async Task<bool> Add(Entry user)
        {
            try
            {
                await _entryRepository.Add(user);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public bool Update(Entry user)
        {
            try
            {
                _entryRepository.Update(user);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public async Task<bool> Delete(int id)
        {
            try
            {
                await _entryRepository.Delete(id);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }
    }
}
