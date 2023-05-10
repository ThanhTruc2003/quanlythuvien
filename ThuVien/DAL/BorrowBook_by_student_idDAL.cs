using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using ThuVien.GUI;

namespace DAL
{
    public class BorrowBook_by_student_idDAL
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public DataTable getData(string student_id)
        {
            string query = "SELECT Borrowers.book_id, BooksStore.book_name, quantity_borrow,quantity_returned, date_of_borrow, date_of_return, status_book " +
                            "FROM Borrowers, Student, BooksStore " +
                            "WHERE Borrowers.student_id = Student.student_id " +
                            "AND BooksStore.book_id = Borrowers.book_id " +
                            "AND Borrowers.student_id = '" + student_id + "'";
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                con.Close();
            }
        }
    }
}
