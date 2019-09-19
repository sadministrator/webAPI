using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class UserRepository
    {
        private List<UserModel> Users = new List<UserModel>();
        public List<UserModel> GetUsers()
        {
            return Users;
        }

        public UserModel GetUserById(int id)
        {
            return Users.Find(user => user.Id.Equals(id));
        }

        public void AddUser(UserModel user) => Users.Add(user);
        
        public void PatchUser(int id, UserModel user)
        {
            var patchedUser = GetUserById(id);
            patchedUser.FirstName = user.FirstName;
            patchedUser.LastName = user.LastName;
            patchedUser.Email = user.Email;
        }

        public void DeleteUser(int id) => Users.Remove(GetUserById(id));
    }
}
