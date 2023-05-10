using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class BorrowBook_by_student_idBUS
    {
        BorrowBook_by_student_idDAL dal = new BorrowBook_by_student_idDAL();
        public DataTable getData(string student_id)
        {
            return dal.getData(student_id);
        }
    }
}
