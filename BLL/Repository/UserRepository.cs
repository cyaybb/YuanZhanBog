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
        public User GetUser(string name)
        {
         return  Users.Where(u => u.Name == name).SingleOrDefault();
        }

        public User Save(User user)
        {
            //user.publish();如果User有直接的方法要调用执行一下
            Users.Add(user);
            SaveChanges();
            return new User();
        }
    }
}
