using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace DAL
{
    public class RegisterDAL
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public bool checkUser(string users_account)
        {
            string querry = "SELECT * FROM UsersInformation WHERE users_account = '" + users_account + "'";
            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dtable = new DataTable();
            sda.Fill(dtable);

            if (dtable.Rows.Count > 0)
            {
                return false;
            }
            return true;
        }

        public bool Insert(RegisterDTO dto_register)
        {

            string sb = string.Format(@"Insert into UsersInformation(
                                        users_name,
                                        users_email, 
                                        users_phone, 
                                        users_address,
                                        users_account,
                                        users_password)values 
                                        (N'{0}','{1}','{2}','{3}','{4}','{5}')", dto_register.users_name, dto_register.users_email, dto_register.users_phone, dto_register.users_address, dto_register.users_account, dto_register.users_password);
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
            return false;
        }
    }
}
