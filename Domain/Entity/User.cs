using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entity
{
    public class  User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string UserName { get; set; }
        public string Pasword { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }



      public  bool VaildPassword()
        {
            if(this.Pasword.Length > 0)
            {
                return true;
            }
            return false;
            
        }


        public bool VaildEmail()
        {
            if (this.Email.Length > 0)
            {
                return true;
            }
            return false;

        }


        public bool VaildUserName()
        {
            if (this.UserName.Length > 0)
            {
                return true;
            }
            return false;
        }

    }
}
