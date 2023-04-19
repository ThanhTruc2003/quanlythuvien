using System;
using System.Data.SqlClient;
using System.Data;
using DTO;
using DAL;

namespace DAL
{
    public class CreateBookDAL
    {
        private SqlConnection conn = new SqlConnection(@"Data Source=DESKTOP-HISKP3B\SQLEXPRESS;Initial Catalog=quanlythuvien;Integrated Security=True");
        public bool Insert(CreateBookDTO dto_book)
        {

            string sb = string.Format(@"Insert into BooksStore (
                                        book_name,
                                        publisher_name, 
                                        quantity, 
                                        available_quantity)values 
                                        (N'{0}','{1}',{2},{3})", dto_book.book_name, dto_book.publisher_name, dto_book.quantity, dto_book.available_quantity);
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
