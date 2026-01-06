using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;

namespace OfficeHoursCalc.Services
{
    public class EntryService : IEntryService
    {
        private readonly IEntryRepository _entryRepository;

        public EntryService(IEntryRepository entryRepository)
        {
            _entryRepository = entryRepository;
        }

        public async Task AddAsync(Entry entry)
        {
            try
            {
                if (entry == null)
                    throw new ArgumentNullException("entry");
                await _entryRepository.AddAsync(entry);
            }
            catch (Exception exp)  
            {
                Console.WriteLine(exp.Message);
                throw new Exception(exp.Message);
            }
        }

        public async Task<IEnumerable<Entry>> GetAllAsync()
        {
            try
            {
                return await _entryRepository.GetAllAsync();
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }
        }

        public IEnumerable<Entry> GetAllByUserId(int userId)
        {
            try
            {
                if(userId < 0) 
                    throw new ArgumentNullException("userId");
                return _entryRepository.GetAllByUserId(userId).ToList();
            }
            catch (Exception exp)
            {

                throw new Exception(exp.Message);
            }
        }

        public Task<Entry?> GetByIdAsync(int entryId)
        {
            throw new NotImplementedException();
        }
    }
}
