using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;
using OfficeHoursCalc.Repositories;
using System.Threading.Tasks;

namespace OfficeHoursCalc.Services
{
    public class UserService : IService<User>
    {
        private readonly IRepository<User> _userRepository;

        public UserService(IRepository<User> userService)
        {
            _userRepository = userService;
        }
        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                return await _userRepository.GetAll();
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public async Task<User> GetById(int id)
        {
            try
            {
                return await _userRepository.GetById(id);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public async Task<bool> Add(User user)
        {
            try
            {
                await _userRepository.Add(user);
                return true;
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
                throw;
            }
        }

        public bool Update(User user)
        {
            try
            {
                _userRepository.Update(user);
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
                await _userRepository.Delete(id);
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
