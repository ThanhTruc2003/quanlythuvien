using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class BorrowBookBUS
    {
        private BorrowBookDAL dal = new BorrowBookDAL();
        public DataTable getData()
        {
            return dal.getData();
        }
        public bool checkStudentID(string student_id)
        {
            return dal.checkStudentID(student_id);
        }
        public bool insertBorrowBook(BorrowBookDTO dto_borrowbook)
        {
            return dal.insertBorrowBook(dto_borrowbook);
        }
    }
}
