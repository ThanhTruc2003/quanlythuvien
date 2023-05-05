using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BookDTO
    {
        public Int32 book_id { get; set; }
        public string book_name { get; set; }
        public string publisher_name { get; set; }
        public Int32 quantity { get; set; }
        public Int32 available_quantity { get; set; }
        public BookDTO()
        {
            this.book_id = 0;
            this.book_name = "";
            this.publisher_name = "";
            this.quantity = 0;
            this.available_quantity = 0;
        }
        public BookDTO(Int32 book_id, string book_name, string publisher_name, Int32 quantity, Int32 available_quantity)
        {
            this.book_id = book_id;
            this.book_name = book_name;
            this.publisher_name = publisher_name;
            this.quantity = quantity;
            this.available_quantity = available_quantity;
        }
    }
}
