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
    public partial class TableBook : Form
    {

        public TableBook()
        {
            InitializeComponent();
        }

        private void TableBook_Load(object sender, EventArgs e)
        {
            TableBookBUS bus = new TableBookBUS();
            dgv.DataSource = bus.getData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateBook CB = new CreateBook();
            CB.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UpdateBook UB = new UpdateBook();
            UB.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Dashboard DB = new Dashboard();
            DB.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            TableBookBUS bus = new TableBookBUS();
            dgv.DataSource = bus.getData();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
            TableBookBUS bus = new TableBookBUS();
            int index = dgv.CurrentCell.RowIndex;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (result == DialogResult.Yes)
            {
                bus.Delete(index);
                dgv.DataSource = bus.getData();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }   
        }
    }
}
