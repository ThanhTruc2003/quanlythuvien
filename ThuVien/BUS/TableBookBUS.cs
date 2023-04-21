using DAL;
using DTO;
using System.Data;

namespace BUS
{
    public class TableBookBUS
    {
        private TableBookDAL dal = new TableBookDAL();
        public DataTable getData()
        {
            return dal.getData();
        }
        public bool Delete(int index)
        {
            return dal.Delete(index);
        }
    }
}
