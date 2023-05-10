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
    public partial class BorrowBook_by_student_id : Form
    {

        public BorrowBook_by_student_id()
        {
            InitializeComponent();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            InformationBook IB = new InformationBook();
            IB.Show();
            this.Hide();
        }

        private void BorrowBook_by_student_id_Load(object sender, EventArgs e)
        {
            string MaSinhVien;
            MaSinhVien = txbMaSinhVien.Text;
            BorrowBook_by_student_idBUS bus = new BorrowBook_by_student_idBUS();
            dgv_BorrowBook.DataSource = bus.getData(MaSinhVien);
        }
    }
}
