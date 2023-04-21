using BUS;
using DTO;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.GUI
{
    public partial class CreateBook : Form
    {
        private DataGridView dgv;
        public CreateBook(DataGridView dgv)
        {
            this.dgv = dgv;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenSach, NhaXuatBan;
            int SoLuong;
           
            TenSach = txbTenSach.Text;
            NhaXuatBan = txbNhaXuatBan.Text;
            SoLuong = Convert.ToInt32(txbSoLuong.Text);
            CreateBookBUS bus = new CreateBookBUS();
            bool isSuccess = bus.Insert(new CreateBookDTO(TenSach, NhaXuatBan, SoLuong, SoLuong));
            if (isSuccess == true)
            {
                MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
                TableBookBUS busTableBookBUS = new TableBookBUS();
                dgv.DataSource = busTableBookBUS.getData();
                this.Hide();
            }
        }
    }
}
