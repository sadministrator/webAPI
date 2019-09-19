using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication8.Models
{
    public class PostModel
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public UserModel User { get; set; }
        public DateTime Date { get; set; }
    }
}
