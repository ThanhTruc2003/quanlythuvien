using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoginDTO
    {
        public string users_account { get; set; }
        public string users_password { get; set; }
        public LoginDTO(string users_account, string users_password)
        {
            this.users_account = users_account;
            this.users_password = users_password;
        }
    }

}
