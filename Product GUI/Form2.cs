using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            Indicator.Top = 50;
            panel2.Visible = true;
            panel4.Visible = false;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Indicator.Top = 90;
            panel3.Visible = true;
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Indicator.Top = 10;
            panel4.Visible= true;
        }
    }
}
