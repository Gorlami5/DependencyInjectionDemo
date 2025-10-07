using DependencyInjectionDemo.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInjectionDemo.Implementations
{
    public class UserService
    {
        private readonly ILogger _logger;
        private readonly IUserRepository _userRepository;
        private readonly IRepository<string> _repo;
        public UserService(ILogger logger, IRepository<string> repo,IUserRepository userRepository)
        {
            _logger = logger;
            _repo = repo;
            _userRepository = userRepository;

        }

        public void UserCreate()
        {
            ///Create process

            _logger.Log("logged");
        }

        public void UseRepo(string s)
        {
            _repo.Add(s);
        }

        public void UseCustomRepo()
        {
            _userRepository.GetUserAndUserPhoneAsync();
        }
    }
}
