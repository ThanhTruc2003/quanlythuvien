using DTO;
using DAL;
using System.Data;
namespace ThuVien.BUS
{
    public class UpdateBookBUS
    {

        private UpdateBookDAL dal = new UpdateBookDAL();
        public UpdateBookDTO getInforBookByID(Int32 book_id)
        {
            return dal.getInforBookByID(book_id);
        }
        public bool updateBook(UpdateBookDTO dto_book)
        {
            return dal.Update(dto_book);
        }
    }
}
