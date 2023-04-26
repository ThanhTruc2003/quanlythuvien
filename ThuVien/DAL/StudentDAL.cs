using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;
using System.Drawing;

namespace DAL
{
    public class StudentDAL
    {
        SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public DataTable getData()
        {
            string querry = "SELECT * FROM Student";
            SqlDataAdapter ada = new SqlDataAdapter(querry, conn);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }
        public bool Insert(StudentDTO dto_student)
        {
            string sb = string.Format(@"Insert into Student(
                                        student_id,
                                        student_name, 
                                        student_phone, 
                                        student_major,
                                        student_address) values 
                                        ('{0}',N'{1}','{2}',N'{3}','{4}')", dto_student.student_id, dto_student.student_name, dto_student.student_phone, dto_student.student_major, dto_student.student_address);
            SqlCommand cmd = new SqlCommand(sb, conn);
            try
            {
                conn.Open();
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
                conn.Close();
            }
            return true;
        }
        public bool checkStudent_ID(string student_id)
        {
            string querry = "SELECT * FROM Student WHERE student_id = '" + student_id + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public bool Delete(StudentDTO dto_student)
        {
            string sb = string.Format(@"Delete from Student 
                                         where student_id = '{0}'", dto_student.student_id);
            SqlCommand cmd = new SqlCommand(sb, conn);
            try
            {
                conn.Open();
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
                conn.Close();
            }
            return true;
        }
        public bool Update(StudentDTO dto_student)
        {

            string sb = string.Format(@"update Student 
                                    set  
                                    student_name = '{0}', 
                                    student_phone = '{1}', 
                                    student_major = '{2}',
                                    student_address = '{3}'
                                    where student_id = '{4}'",
                                    dto_student.student_name, dto_student.student_phone,
                                    dto_student.student_major, dto_student.student_address,
                                    dto_student.student_id);
            SqlCommand cmd = new SqlCommand(sb, conn);
            try
            {
                conn.Open();
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
                conn.Close();
            }
            return true;
        }
    }
}
