using DependencyInjectionDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Implementations
{
    public  class UserRepository : RepositoryBase<UserRepository>,IUserRepository
    {
        public void GetUserAndUserPhoneAsync()
        {
            ///await sth
            Console.WriteLine("UserRepo success!");
        }
    }
}
