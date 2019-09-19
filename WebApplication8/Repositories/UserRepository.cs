using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication8.Models;

namespace WebApplication8.Repositories
{
    public class UserRepository
    {
        public List<UserModel> GetUsers()
        {
            return new List<UserModel> {
                new UserModel {
                    Id = 1,
                    FirstName = "Pedro",
                    LastName = "Suarez"
                },
                new UserModel {
                    Id = 2,
                    FirstName = "Miryam",
                    LastName = "Ruiz"
                }
            };
        }
    }
}
