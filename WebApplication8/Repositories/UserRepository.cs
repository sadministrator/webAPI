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
    }
}
