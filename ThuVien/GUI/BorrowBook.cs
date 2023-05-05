using BUS;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ThuVien.BUS;

namespace ThuVien.GUI
{
    public partial class BorrowBook : Form
    {
        private DataTable dt;
        private DataTable booksSelected = new DataTable();
        public BorrowBook()
        {
            InitializeComponent();
            this.booksSelected.Columns.Add("book_id", typeof(string));
            this.booksSelected.Columns.Add("book_name", typeof(string));
            this.booksSelected.Columns.Add("quantity_borrow", typeof(string));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void BorrowBook_Load(object sender, EventArgs e)
        {
            BorrowBookBUS bus = new BorrowBookBUS();
            this.dt = bus.getData();
            cbo.DataSource = this.dt;
            cbo.ValueMember = "book_id";
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbo.SelectedIndex;
            if (index >= 0)
            {
                BorrowBookBUS bus = new BorrowBookBUS();
                DataRow dr = this.dt.Rows[index];
                txbBookName.Text = dr["book_name"].ToString();
                txbAvailableQuantity.Text = dr["available_quantity"].ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txbQuantity_Borrow.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                int index = cbo.SelectedIndex;
                DataRow dr = this.dt.Rows[index];
                DataRow newRow = this.booksSelected.NewRow();
                newRow["book_id"] = dr["book_id"].ToString();
                newRow["book_name"] = txbBookName.Text;
                newRow["quantity_borrow"] = txbQuantity_Borrow.Text;
                this.booksSelected.Rows.Add(newRow);
                dgv.DataSource = this.booksSelected;
                if (this.dt.Rows.Count > 0)
                {
                    this.dt.Rows.Remove(this.dt.Rows[index]);
                }
                txbBookName.Text = "";
                txbAvailableQuantity.Text = "";
                txbQuantity_Borrow.Text = "";
            }    
        }

        private void btHoanTat_Click(object sender, EventArgs e)
        {
            DateTime date = dateTimePicker1.Value.Date;
            DateTime now = DateTime.Now;
            string MaSinhVien;
            MaSinhVien = txbMaSinhVien.Text;
            BorrowBookBUS bus = new BorrowBookBUS();
            bool checkStudentID = bus.checkStudentID(MaSinhVien);
            if (checkStudentID == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                foreach (DataRow row in this.booksSelected.Rows)
                {
                    BorrowBookDTO dto = new BorrowBookDTO();
                    int book_id = Convert.ToInt32(row["book_id"].ToString());
                    int quantity_borrow = Convert.ToInt32(row["quantity_borrow"].ToString());
                    dto.book_id = book_id;
                    dto.quantity_borrow = quantity_borrow;
                    dto.date_of_borrow = now;
                    dto.date_of_return = date;
                    dto.student_id = MaSinhVien;
                    dto.note = "";
                    bus.insertBorrowBook(dto);
                }
                MessageBox.Show("Mượn sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard DB = new Dashboard();
                DB.Show();
                this.Hide();
            }
        }
    }
}
