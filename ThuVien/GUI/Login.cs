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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Show_Hide_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Hide.Checked)
            {
                txbMatkhau.UseSystemPasswordChar = true;
            }    
            else
            {
                txbMatkhau.UseSystemPasswordChar = false;
            }    
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Register R = new Register();
            R.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string TaiKhoan, MatKhau;
            TaiKhoan = txbTaikhoan.Text;
            MatKhau = txbMatkhau.Text;
            LoginBUS bus = new LoginBUS();
            bool isSuccess = bus.Check(new LoginDTO(TaiKhoan, MatKhau));
            if (isSuccess == true)
            {
                MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Dashboard DB = new Dashboard();
                DB.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Đăng nhập không thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
