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
    public partial class DisplayAllProducts : Form
    {
        public DisplayAllProducts()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var product = Product.findOne(textBox1.Text);
            if (product == null)
            {
                MessageBox.Show("Not Found");
            }

        }
    }
}
