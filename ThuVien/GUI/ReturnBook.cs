using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThuVien.GUI
{
    public partial class ReturnBook : Form
    {
        private DataTable cbo_dt;
        private DataTable booksSelected = new DataTable();
        public ReturnBook()
        {
            InitializeComponent();
            this.booksSelected.Columns.Add("book_id", typeof(string));
            this.booksSelected.Columns.Add("book_name", typeof(string));
            this.booksSelected.Columns.Add("quantity_returned", typeof(string));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void btNhap_Click(object sender, EventArgs e)
        {
            string MaSinhVien, SoLuongMuon;
            MaSinhVien = txbMaSinhVien.Text;
            SoLuongMuon = txbQuantity_Borrow.Text;
            ReturnBookBUS bus = new ReturnBookBUS();
            bool checkStudentID = bus.checkStudentID(MaSinhVien);
            if(checkStudentID == false)
            {
                MessageBox.Show("Mã sinh viên không tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else
            {
                this.cbo_dt = bus.getData(MaSinhVien);
                if (this.cbo_dt.Rows.Count > 0)
                {
                    cbo.DataSource = this.cbo_dt;
                    cbo.ValueMember = "book_id";
                }
                else
                {
                    MessageBox.Show("Sinh viên không mượn cuốn sách nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            
        }

        private void cbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbo.SelectedIndex;
            if (index >= 0)
            {
                DataRow dr = this.cbo_dt.Rows[index];
                txbQuantity_Borrow.Text = (Convert.ToInt16(dr["quantity_borrow"]) - Convert.ToInt16(dr["quantity_returned"])).ToString();
            }
        }

        private void btThem_Click(object sender, EventArgs e)
        {
            if (txbQuantity_Return.Text == "")
            {
                MessageBox.Show("Vui lòng điền thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (Convert.ToInt32(txbQuantity_Return.Text) > Convert.ToInt32(txbQuantity_Borrow.Text))
                {
                    MessageBox.Show("Số lượng trả lớn hơn số lượng mượn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
                else
                {
                    int index = cbo.SelectedIndex;
                    DataRow dr = this.cbo_dt.Rows[index];
                    DataRow newRow = this.booksSelected.NewRow();
                    newRow["book_id"] = dr["book_id"].ToString();
                    newRow["book_name"] = dr["book_name"].ToString();
                    newRow["quantity_returned"] = txbQuantity_Return.Text;
                    this.booksSelected.Rows.Add(newRow);
                    dgv.DataSource = this.booksSelected;
                    if (this.cbo_dt.Rows.Count > 0)
                    {
                        this.cbo_dt.Rows.Remove(this.cbo_dt.Rows[index]);
                    }
                    txbQuantity_Borrow.Text = "";
                    txbQuantity_Return.Text = "";
                }
            }
        }
        private void btHoanTat_Click(object sender, EventArgs e)
        {

            foreach (DataRow row in this.booksSelected.Rows)
            {
                ReturnBookBUS bus = new ReturnBookBUS();
                string MaSinhVien;
                MaSinhVien = txbMaSinhVien.Text;
                int book_id = Convert.ToInt32(row["book_id"].ToString());
                DataTable dt = bus.getDataRow(book_id, MaSinhVien);
                DataRow dr = dt.Rows[0];
                int SoLuongTraMoi = Convert.ToInt32(row["quantity_returned"].ToString()) + Convert.ToInt32(dr["quantity_returned"].ToString());
                string status = dr["status_book"].ToString();
                if (SoLuongTraMoi == Convert.ToInt32(dr["quantity_borrow"].ToString()))
                {
                    status = "Đã trả";
                }
                bus.updateData(SoLuongTraMoi, status, book_id, MaSinhVien);
            }
            MessageBox.Show("Trả sách thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }
    }
}
