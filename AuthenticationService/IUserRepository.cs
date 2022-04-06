using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AuthenticationService
{
    public interface IUserRepository
    {
        public IEnumerable<User> GetAll();
        public User GetByLogin(string login);
    }
}
