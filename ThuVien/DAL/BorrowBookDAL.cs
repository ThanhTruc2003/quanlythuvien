using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using ThuVien.GUI;

namespace DAL
{
    public class BorrowBookDAL
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public DataTable getData()
        {
            string query = string.Format(@"SELECT * FROM BooksStore");
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
        public bool checkStudentID(string student_id)
        {
            string querry = "SELECT * FROM Student WHERE student_id = '" + student_id + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool insertBorrowBook(BorrowBookDTO dto_borrowbook)
        {
            string query = string.Format(@"Insert into Borrowers (
                                        student_id,
                                        book_id, 
                                        quantity_borrow, 
                                        quantity_returned,
                                        date_of_borrow,
                                        date_of_return,
                                        note,
                                        status_book) values 
                                        (N'{0}',{1},{2},{3},'{4}','{5}','{6}',N'{7}')", dto_borrowbook.student_id, dto_borrowbook.book_id, dto_borrowbook.quantity_borrow, 0, dto_borrowbook.date_of_borrow, dto_borrowbook.date_of_return, dto_borrowbook.note, "Chưa trả");
            SqlCommand cmd = new SqlCommand(query, con);
            try
            {
                con.Open();
                if (cmd.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (SqlException ex1)
            {

                throw ex1;
            }
            finally
            {
                con.Close();
            }
            return true;
        }
    }
}
