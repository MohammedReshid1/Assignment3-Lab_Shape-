using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinApp.Model_Item;

namespace WinApp
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var products = Item.findOne(textBox1.Text);
            if (products == null)
            {

                MessageBox.Show("Enter Something");
            }
            else
            {
                label6.Text = products.object_name;
                label7.Text = products.price;
                label8.Text = products.count;
                label9.Text = products.number;
             //   label10.Text = products.inventory_number;

            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
