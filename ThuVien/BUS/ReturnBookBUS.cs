using DTO;
using DAL;
using System.Data;
using System.Data.SqlClient;

namespace BUS
{
    public class ReturnBookBUS
    {
        ReturnBookDAL dal = new ReturnBookDAL();
        public bool checkStudentID(string student_id)
        {
            return dal.checkStudentID(student_id);
        }
        public DataTable getData(string student_id)
        {
            return dal.getData(student_id);
        }
        public DataTable getDataRow(int book_id, string student_id)
        {
            return dal.getDataRow(book_id, student_id);
        }
        public bool updateData(int quantity_returned, string status_book, int book_id, string student_id)
        {
            return dal.updateData(quantity_returned, status_book, book_id, student_id);
        }
    }
}
