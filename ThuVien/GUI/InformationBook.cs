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
    public partial class InformationBook : Form
    {
        public InformationBook()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string selectedRow = Selected();
            BorrowBook_by_student_id BB = new BorrowBook_by_student_id();
            BB.txbMaSinhVien.Text = dgv.CurrentRow.Cells[0].Value.ToString();
            BB.txbHoTen.Text = dgv.CurrentRow.Cells[1].Value.ToString();
            BB.Show();
            this.Hide();
        }
        private void InformationBook_Load(object sender, EventArgs e)
        {
            InformationBookBUS bus = new InformationBookBUS();
            dgv.DataSource = bus.status_bookByStudent();
        }
        private string Selected()
        {
            int selectedIndex = dgv.SelectedCells[0].RowIndex; ;
            DataGridViewRow selected = dgv.Rows[selectedIndex];
            string selectedID = selected.Cells[0].Value.ToString();
            return selectedID;
        }
    }
}
