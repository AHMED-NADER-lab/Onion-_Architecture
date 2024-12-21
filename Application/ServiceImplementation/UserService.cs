using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;
using Service.IRepositories;
using Service.IServiceInterface;

namespace Application.ServiceImplementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepositories userRepositories;

        public UserService(IUserRepositories _userRepositories)
        {
            userRepositories = _userRepositories;
        }
        public bool AddUser(User user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(int Id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllUser()
        {
            throw new NotImplementedException();
        }

        public User GetUser(int Id)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
