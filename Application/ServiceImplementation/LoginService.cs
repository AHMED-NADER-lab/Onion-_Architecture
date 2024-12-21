using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application.IRepositories;
using Application.IServiceInterface;


namespace Application.ServiceImplementation
{
    public class LoginService : ILoginService
    {
        private readonly IUserRepositories userRepositories;

        public LoginService(IUserRepositories _userRepositories)
        {
            userRepositories = _userRepositories;
        }
        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }
    }
}
