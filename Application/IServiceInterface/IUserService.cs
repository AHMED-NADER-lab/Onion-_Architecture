using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Application.IServiceInterface
{
    public interface IUserService
    {
        bool AddUser(User user);
        bool UpdateUser(User user);
        bool DeleteUser(int Id);
        List<User> GetAllUser();
        User GetUser(int Id);
    }
}
