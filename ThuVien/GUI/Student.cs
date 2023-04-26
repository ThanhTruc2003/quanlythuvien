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
 
        private void button3_Click(object sender, EventArgs e)
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
                    MessageBox.Show("Tên sinh viên đã tồn tại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
