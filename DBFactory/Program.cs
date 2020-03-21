using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            using (UserRepository userRepository = new UserRepository())
            {
                var db = userRepository.Database;
                db.Delete();
                //Database.Delete("YuanZhan");
                db.Create();
                List<User> users = new List<User>
            {
                new User{Name="叶飞1",Password="1234",InviterId=1,InviteCode=1111 },
                new User{Name="叶飞2",Password="1234",InviterId=1,InviteCode=2222 },
                new User{Name="叶飞3",Password="1234",InviterId=2,InviteCode=2222 },
                new User{Name="叶飞4",Password="1234",InviterId=3,InviteCode=3333 },
                new User{Name="叶飞5",Password="1234",InviterId=4,InviteCode=4444 },
            };
                foreach (var item in users)
                {
                    userRepository.Save(item);
                }
            }
        }
    }
}
