using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class RegisterDTO
    {
        public string users_name { get; set; }
        public string users_email { get; set; }
        public string users_phone { get; set; }
        public string users_address { get; set; }
        public string users_account { get; set; }
        public string users_password { get; set; }

        public RegisterDTO(string users_name, string users_email, string users_phone, string users_address, string users_account, string users_password)
        {
            this.users_name = users_name;
            this.users_email = users_email;
            this.users_phone = users_phone;
            this.users_address = users_address;
            this.users_account = users_account;
            this.users_password = users_password;
        }
    }
}
