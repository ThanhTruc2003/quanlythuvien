using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAL;
using DTO;
using ThuVien.BUS;

namespace ThuVien.GUI
{
    public partial class UpdateBook : Form
    {
        private DataGridView dgv;
        private int book_id = -1;
        private UpdateBookDTO dto = new UpdateBookDTO();
        public UpdateBook(int book_id, DataGridView dgv)
        {
            this.dgv = dgv;
            this.book_id = book_id;
            InitializeComponent();
            UpdateBookBUS bus = new UpdateBookBUS();
            dto = bus.getInforBookByID(book_id);
            lbBook_ID.Text = Convert.ToString(dto.book_id);
            txbTenSach.Text = dto.book_name;
            txbNhaXuatBan.Text = dto.publisher_name;
            txbSoLuong.Text = Convert.ToString(dto.quantity);
            txbSoLuongCoSan.Text = Convert.ToString(dto.available_quantity);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TenSach, NhaXuatBan;
            int ID, SoLuong, SoLuongCoSan;

            TenSach = txbTenSach.Text;
            NhaXuatBan = txbNhaXuatBan.Text;
            SoLuong = Convert.ToInt32(txbSoLuong.Text);
            SoLuongCoSan = Convert.ToInt32(txbSoLuongCoSan.Text);
            ID = Convert.ToInt32(lbBook_ID.Text);
            UpdateBookBUS bus = new UpdateBookBUS();
            bool isSuccess = bus.updateBook(new UpdateBookDTO(ID, TenSach, NhaXuatBan, SoLuong, SoLuongCoSan));
            if (isSuccess == true)
            {
                MessageBox.Show("Sửa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TableBookBUS busTableBookBUS = new TableBookBUS();
                dgv.DataSource = busTableBookBUS.getData();
                this.Hide();
            }    
        }
    }
}
