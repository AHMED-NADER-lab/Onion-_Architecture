using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entity;

namespace Infrastructure.DBContext
{
    public class OnionContext
    {
        public List<User> UserList { get; set; }
        public OnionContext() {

            UserList.Add(new User()
            {
                Id=1,
                Email="test1@yahoo.com",
                FullName="test1",
                Pasword="123",
                Phone="012584525",
                UserName="atest1"
            });
            UserList.Add(new User()
            {
                Id = 2,
                Email = "test2@yahoo.com",
                FullName = "test2",
                Pasword = "123",
                Phone = "012584525",
                UserName = "atest2"
            });
            UserList.Add(new User()
            {
                Id = 3,
                Email = "test3@yahoo.com",
                FullName = "test3",
                Pasword = "123",
                Phone = "012584525",
                UserName = "atest3"
            });


        }
    }
}
