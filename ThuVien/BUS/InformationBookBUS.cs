using DTO;
using DAL;
using System.Data;

namespace BUS
{
    public class InformationBookBUS
    {
        InformationBookDAL dal = new InformationBookDAL();
        public DataTable getData()
        {
            return dal.getData();
        }
        public DataTable status_bookByStudent()
        {
            return dal.status_bookByStudent();
        }
    }
}
