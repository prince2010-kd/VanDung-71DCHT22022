using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VanDung_71DCHT22022
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKq_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtA.Text.Trim());
            if (txtA.Text == "")
            {
                MessageBox.Show("Nhập a đi!");
                return;
            }
            

            int b = int.Parse(txtB.Text.Trim());

            int c = int.Parse(txtC.Text.Trim());

            if (a == 0 && b == 0 && c != 0)
            {
                MessageBox.Show("phương trình không có nghiệm:))))");
                return;
            }

            int d = b * b - 4 * a * c;
            if (d < 0)
            {
                MessageBox.Show("Phương trình vô nghiệm:");
                return;
            }
            else if (d == 0)
            {
                MessageBox.Show("Phương trình có nghiệm kép:");
                decimal kq = -b / 2 * a;
            }
            else 
            {
                decimal kq = Convert.ToDecimal((-b) + Math.Sqrt(d)) / (2 * a);
                decimal kq2 = Convert.ToDecimal((-b) - Math.Sqrt(d)) / (2 * a);
                MessageBox.Show("Phương trình có 2 nghiệm là x1 = "   + kq.ToString() + "\r\n  x2 = " + kq2.ToString());
                return;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblX_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtC_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtA_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblkq_Click(object sender, EventArgs e)
        {

        }
    }
}
