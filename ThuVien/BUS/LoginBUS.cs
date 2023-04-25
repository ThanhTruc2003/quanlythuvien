using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class LoginBUS
    {
        private LoginDAL dal = new LoginDAL();
        public bool Check(LoginDTO dto_Login)
        {
            if (dal.checkUser(dto_Login.users_account, dto_Login.users_password))
            {
                return true;
            }
            return false;
        }
    }
}
