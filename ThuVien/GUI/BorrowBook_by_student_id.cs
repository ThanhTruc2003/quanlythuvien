using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
