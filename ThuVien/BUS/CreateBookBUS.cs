using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class CreateBookBUS
    {
        private CreateBookDAL dal = new CreateBookDAL();
        public bool Insert(CreateBookDTO dto_book)
        {
            return dal.Insert(dto_book);
        }
    }
}
