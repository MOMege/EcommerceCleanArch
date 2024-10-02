using Ecommerce.application.Repository;
using ECOMMERCE.DOMAIN;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.application.Contract.Service
{
    public class UserService : IuserRepository
    {
        private readonly IuserRepository _userRepository;
        public UserService( IuserRepository iuserRepository) {
        _userRepository = iuserRepository;
        }
        public Task<User> AddAsync(User entity)
        {

            return _userRepository.AddAsync(entity);
            
        }

        public Task DeleteAsync(int id)
        {
            return _userRepository.DeleteAsync(id);
            
        }

        public Task<IEnumerable<User>> GetAllAsync()
        {
            return _userRepository.GetAllAsync();
           
        }

        public Task<User> GetByIdAsync(int id)
        {
          return _userRepository.GetByIdAsync(id);
            
        }

        public Task<User> UpdateAsync(User entity)
        {
            return _userRepository.UpdateAsync(entity);
           
        }
    }
}
