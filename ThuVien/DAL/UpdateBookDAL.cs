using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace DAL
{
    public class UpdateBookDAL
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public UpdateBookDTO getInforBookByID(Int32 book_id)
        {
            UpdateBookDTO updateBookDTO = new UpdateBookDTO();
            string str = string.Format(@"SELECT * FROM BooksStore
                                           where book_id = {0}", book_id);
            SqlCommand cmd = new SqlCommand(str, conn);
            try
            {
                conn.Open();
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    updateBookDTO.book_id = Convert.ToInt32(dr["book_id"]);
                    updateBookDTO.book_name = Convert.ToString(dr["book_name"]);
                    updateBookDTO.publisher_name = Convert.ToString(dr["publisher_name"]);
                    updateBookDTO.quantity = Convert.ToInt32(dr["quantity"]);
                    updateBookDTO.available_quantity = Convert.ToInt32(dr["available_quantity"]);
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
            return updateBookDTO;
        }
        public bool Update(UpdateBookDTO dto_book)
        {

            string sb = string.Format(@"update BooksStore 
                                    set book_name = N'{0}', 
                                    publisher_name = N'{1}', 
                                    quantity = {2}, 
                                    available_quantity = {3}
                                    where book_id = {4}",
                                    dto_book.book_name, dto_book.publisher_name, 
                                    dto_book.quantity, dto_book.available_quantity, 
                                    dto_book.book_id);
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
