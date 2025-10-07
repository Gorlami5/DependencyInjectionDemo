using DependencyInjectionDemo.Implementations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Interfaces
{
    public interface IUserRepository : IRepository<UserRepository>
    {
        void GetUserAndUserPhoneAsync();
    }
}
