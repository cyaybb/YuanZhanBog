using Entity;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdService
{
    public class UserService
    {
        public UserRepository _userRepository;
        public UserService()
        {
            _userRepository = new UserRepository();
        }
        public User GetUser(string name)
        {
            return _userRepository.GetUser(name);
        }
        public bool IsGetUser(string name)
        {
            return _userRepository.GetUser(name) != null;
        }
    }
}
