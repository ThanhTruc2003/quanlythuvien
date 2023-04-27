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
    public partial class Student : Form
    {
        public Student()
        {

            InitializeComponent();
        }
        private void Student_Load(object sender, EventArgs e)
        {
            StudentBUS bus = new StudentBUS();
            dgv.DataSource = bus.getData();
        }

        private void Create_Click(object sender, EventArgs e)
        {
            string MaSo, HoTen, SoDienThoai, Nganh, DiaChi;
            MaSo = txbMaSo.Text;
            HoTen = txbHoTen.Text;
            SoDienThoai = txbSoDienThoai.Text;
            Nganh = txbNganh.Text;
            DiaChi = txbDiaChi.Text;
            StudentBUS bus = new StudentBUS();
            if (txbMaSo.Text == "" && txbHoTen.Text == "" && txbSoDienThoai.Text == "" && txbNganh.Text == "" && txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaSo.Text == "" || txbHoTen.Text == "" || txbSoDienThoai.Text == "" || txbNganh.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isSuccess = bus.Insert(new StudentDTO(MaSo, HoTen, SoDienThoai, Nganh, DiaChi));
                if (isSuccess == false)
                {
                    MessageBox.Show("Mã số sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentBUS busStudentBUS = new StudentBUS();
                    dgv.DataSource = busStudentBUS.getData();
                    txbMaSo.Text = "";
                    txbHoTen.Text = "";
                    txbSoDienThoai.Text = "";
                    txbNganh.Text = "";
                    txbDiaChi.Text = "";
                }
            }
        }

        private string Selected()
        {
            int selectedIndex = dgv.SelectedCells[0].RowIndex; ;
            DataGridViewRow selected = dgv.Rows[selectedIndex];
            string selectedID = selected.Cells[0].Value.ToString();
            return selectedID;
        }
        private void Delete_Click(object sender, EventArgs e)
        {
            string student_selected = Selected();
            StudentBUS bus = new StudentBUS();
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bus.Delete(student_selected);
                dgv.DataSource = bus.getData();
                txbMaSo.Text = "";
                txbHoTen.Text = "";
                txbSoDienThoai.Text = "";
                txbNganh.Text = "";
                txbDiaChi.Text = "";
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                int index = e.RowIndex;
                DataGridViewRow selected = dgv.Rows[index];
                txbMaSo.Text = selected.Cells[0].Value.ToString();
                txbHoTen.Text = selected.Cells[1].Value.ToString();
                txbSoDienThoai.Text = selected.Cells[2].Value.ToString();
                txbNganh.Text = selected.Cells[3].Value.ToString();
                txbDiaChi.Text = selected.Cells[4].Value.ToString();
        }
        private void Update_Click(object sender, EventArgs e)
        {
            string MaSo, HoTen, SoDienThoai, Nganh, DiaChi;
            MaSo = txbMaSo.Text;
            HoTen = txbHoTen.Text;
            SoDienThoai = txbSoDienThoai.Text;
            Nganh = txbNganh.Text;
            DiaChi = txbDiaChi.Text;
            StudentBUS bus = new StudentBUS();
            if (txbMaSo.Text == "" && txbHoTen.Text == "" && txbSoDienThoai.Text == "" && txbNganh.Text == "" && txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txbMaSo.Text == "" || txbHoTen.Text == "" || txbSoDienThoai.Text == "" || txbNganh.Text == "" || txbDiaChi.Text == "")
            {
                MessageBox.Show("Vui lòng nhập thông tin", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                bool isSuccess = bus.Update(new StudentDTO(MaSo, HoTen, SoDienThoai, Nganh, DiaChi));
                if (isSuccess == true)
                {
                    MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StudentBUS busStudentBUS = new StudentBUS();
                    dgv.DataSource = busStudentBUS.getData();
                }
            }
        }
        private void Exit_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }
    }
}
