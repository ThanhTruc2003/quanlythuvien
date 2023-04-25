using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace DAL
{
    public class TableBookDAL
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public DataTable getData()
        {
            string querry = "SELECT * FROM BooksStore";
            SqlDataAdapter ada = new SqlDataAdapter(querry, con);
            DataTable table = new DataTable();
            ada.Fill(table);
            return table;
        }
        public bool Delete(int index)
        {
            string sb = string.Format(@"Delete from BooksStore 
                                         where book_id = {0}", index);
            SqlCommand cmd = new SqlCommand(sb, con);
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
