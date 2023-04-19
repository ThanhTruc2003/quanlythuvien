using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CreateBookDTO
    {
        public string book_name { get; set; }
        public string publisher_name { get; set; }
        public Int32 quantity { get; set; }
        public Int32 available_quantity { get; set; }

        public CreateBookDTO( string book_name, string publisher_name, Int32 quantity, Int32 available_quantity)
        {
            this.book_name = book_name;
            this.publisher_name = publisher_name;
            this.quantity = quantity;
            this.available_quantity = available_quantity;
        }
    }
}
