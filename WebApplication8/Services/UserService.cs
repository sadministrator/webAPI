using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;
using WebApplication8.Repositories;

namespace WebApplication8.Services
{
    public class UserService
    {
        private UserRepository _userRepository;

        public UserService(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<UserModel> GetUsers()
        {
            return _userRepository.GetUsers();
        }

        public UserModel GetUserById(int id)
        {
            return _userRepository.GetUserById(id);
        }

        public void AddUser(UserModel user) => _userRepository.AddUser(user);
        
        public void PatchUser(int id, UserModel user) => _userRepository.PatchUser(id, user);

        public void DeleteUser(int id) => _userRepository.DeleteUser(id);
    }
}
