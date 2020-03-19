using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserRepository : DbContext
    {
        public DbSet<User> Users { get; set; }

        public User Save()
        {
            return new User();
        }
    }
}
