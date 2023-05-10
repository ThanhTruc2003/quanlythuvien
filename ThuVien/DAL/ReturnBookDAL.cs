using System;
using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using ThuVien.GUI;

namespace DAL
{
    public class ReturnBookDAL
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public bool checkStudentID(string student_id)
        {
            string querry = "SELECT * FROM Borrowers WHERE student_id = '" + student_id + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, con);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public DataTable getData(string student_id)
        {
            string query = "SELECT * FROM Borrowers, BooksStore " +
                            "where Borrowers.book_id = BooksStore.book_id " +
                            "AND Borrowers.student_id = '" + student_id + "'" +
                            "AND Borrowers.status_book = N'Chưa trả'";


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
        public bool insertReturnBook(ReturnBookDTO dto_returnbook)
        {
            string query = string.Format(@"Insert into Borrowers (
                                        student_id,
                                        book_id, 
                                        quantity_borrow, 
                                        quantity_returned,
                                        date_of_borrow,
                                        date_of_return,
                                        status_book) values 
                                        (N'{0}',{1},{2},{3},'{4}','{5}',N'{7}')", dto_returnbook.student_id, dto_returnbook.book_id, dto_returnbook.quantity_borrow, dto_returnbook.quantity_returned, dto_returnbook.date_of_borrow, dto_returnbook.date_of_return, "Đã trả");
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
        public DataTable getDataRow(int book_id, string student_id)
        {
            string query = "SELECT * FROM Borrowers WHERE book_id = '" + book_id + "' AND student_id = '" + student_id + "'";
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
        public bool updateData(int quantity_returned, string status_book, int book_id, string student_id)
        {
            string query = "UPDATE Borrowers SET quantity_returned = '" + quantity_returned + "', status_book = N'" + status_book + "' WHERE student_id = '" + student_id + "' AND book_id = '" + book_id + "'";
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

                return false;
            }
            finally
            {
                con.Close();
            }
            return false;
        }

    }
}
