using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class RegisterBUS
    {
        private RegisterDAL dal = new RegisterDAL();
        public bool Insert(RegisterDTO dto_register)
        {
            if (dal.checkUser(dto_register.users_account))
            {
                return true;
            }
            return dal.Insert(dto_register);
        }
    }
}
