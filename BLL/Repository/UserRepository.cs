using Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Repository
{
    public class UserRepository : DbContext
    {
        static readonly string connectionString = ConfigurationManager.ConnectionStrings["YuanZhan"].ConnectionString;
        public DbSet<User> Users { get; set; }
        public UserRepository() : base("YuanZhan")
        {
        }
        public User Save()
        {
            return new User();
        }
    }
}
