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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            Login LG = new Login();
            LG.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String HoTen, Email, SoDienThoai, DiaChi, TaiKhoan, Matkhau;
            HoTen = txbHoTen.Text;
            Email = txbEmail.Text;
            SoDienThoai = txbSoDienThoai.Text;
            DiaChi = txbDiaChi.Text;
            TaiKhoan = txbTaiKhoan.Text;
            Matkhau = txbMatKhau.Text;
            RegisterBUS bus = new RegisterBUS();
            bool isSuccess = bus.Insert(new RegisterDTO(HoTen, Email, SoDienThoai, DiaChi, TaiKhoan, Matkhau));
            if (isSuccess == true)
            {
                MessageBox.Show("Đăng ký thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Login LG = new Login();
                LG.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Tài khoản đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
