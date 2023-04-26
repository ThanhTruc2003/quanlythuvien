using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class StudentDTO
    {
        public string student_id { get; set; }
        public string student_name { get; set; }
        public string student_phone { get; set; }
        public string student_major { get; set; }
        public string student_address { get; set; }
        
        public StudentDTO(string student_id, string student_name, string student_phone, string student_major, string student_address)
        {
            this.student_id = student_id;
            this.student_name = student_name;
            this.student_phone = student_phone;
            this.student_major = student_major;
            this.student_address = student_address;
        }
    }
}
