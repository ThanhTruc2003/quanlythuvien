using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BorrowBookDTO
    {
        public Int32 Borrower_number { get; set; }
        public string student_id { get; set; }
        public Int32 book_id { get; set; }
        public Int32 quantity_borrow { get; set; }
        public Int32 quantity_returned { get; set; }
        public DateTime date_of_borrow { get; set; }
        public DateTime date_of_return { get; set; }
        public string note { get; set; }
        public string status_book { get; set; }

        public BorrowBookDTO()
        {

        }
        public BorrowBookDTO(Int32 Borrower_number, string student_id, Int32 book_id, Int32 quantity_borrow, Int32 quantity_returned, DateTime date_of_borrow, DateTime date_of_return, string note, string status_book )
        {
            this.Borrower_number = Borrower_number;
            this.student_id = student_id;
            this.book_id = book_id;
            this.quantity_borrow = quantity_borrow;
            this.quantity_returned = quantity_returned;
            this.date_of_borrow = date_of_borrow;
            this.date_of_return = date_of_return;
            this.note = note;
            this.status_book = status_book;
        }
    }
}
