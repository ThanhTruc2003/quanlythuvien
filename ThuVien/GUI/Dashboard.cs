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
    public partial class Dashboard : Form
    {
        bool isThoat = true;
        public Dashboard()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isThoat)
            {
                Application.Exit();
            }    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TableBook TB = new TableBook();
            TB.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Student S = new Student();
            S.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BorrowBook BB = new BorrowBook();
            BB.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ReturnBook RB = new ReturnBook();
            RB.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InformationBook IB = new InformationBook();
            IB.Show();
            this.Hide();
        }
    }
}
