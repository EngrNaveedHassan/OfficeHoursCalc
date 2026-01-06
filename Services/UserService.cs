using OfficeHoursCalc.Entities;
using OfficeHoursCalc.Interfaces;
using OfficeHoursCalc.Models;
using System.Threading.Tasks;

namespace OfficeHoursCalc.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task AddAsync(User user)
        {
            try
            {
                if (user != null)
                {
                    await _userRepository.AddAsync(user);
                }
                else
                {
                    throw new NullReferenceException("user");
                }
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
                throw new Exception();
            }
        }

        public Task DeleteAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetByIdAsync(int userId)
        {
            throw new NotImplementedException();
        }

        public async Task<UserViewModel> GetCurrentUserAsync()
        {
            try
            {
                // Implement latter on auth
                var user = await _userRepository.GetByIdAsync(1);
                if (user != null)
                    return new UserViewModel
                    {
                        Id = user.Id,
                        Name = user.Name,
                        Entries = user.Entries,
                    };
                else
                    return new UserViewModel();
            }
            catch (Exception exp)
            {
                throw new Exception(exp.Message);
            }
        }

        public Task UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }
    }
}
