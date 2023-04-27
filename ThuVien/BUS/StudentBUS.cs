using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class StudentBUS
    {
        private StudentDAL dal = new StudentDAL();
        public DataTable getData()
        {
            return dal.getData();
        }
        public bool Insert(StudentDTO dto_student)
        {
            if (dal.checkStudent_ID(dto_student.student_id))
            {
                return false;
            }
            return dal.Insert(dto_student);
        }
        public bool Delete(string student_id)
        {
            return dal.Delete(student_id);
        }
        public bool Update(StudentDTO dto_student)
        {
            return dal.Update(dto_student);
        }
    }
}
