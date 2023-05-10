using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using ThuVien.GUI;
using System.Windows.Forms;

namespace DAL
{
    public class InformationBookDAL
    {
        private SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public DataTable getData()
        {
            string query = "SELECT Student.student_id, Student.student_name, Borrowers.status_book " +
                            "FROM Student, Borrowers " +
                            "WHERE Student.student_id = Borrowers.student_id " +
                            "GROUP BY Student.student_id, Student.student_name, Borrowers.status_book";
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
        public DataTable status_bookByStudent()
        {
            string query = "SELECT Student.student_id, Student.student_name, Borrowers.status_book " +
                           "FROM Student, Borrowers " +
                           "WHERE Student.student_id = Borrowers.student_id " +
                           "AND Borrowers.status_book = N'Chưa trả' " +
                           "UNION " +
                           "SELECT Student.student_id, Student.student_name, Borrowers.status_book " +
                           "FROM Student, Borrowers " +
                           "WHERE Student.student_id = Borrowers.student_id " +
                           "AND Borrowers.status_book = N'Đã trả' " +
                           "AND Student.student_id NOT IN " +
                                "(SELECT Student.student_id " +
                                "FROM Student, Borrowers " +
                                "WHERE Student.student_id = Borrowers.student_id " +
                                "AND Borrowers.status_book = N'Chưa trả' " +
                                "GROUP BY Student.student_id)";
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
