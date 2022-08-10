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
    public partial class Major : Form
    {
        public Major()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView2.DataSource = null;
            dataGridView2.DataSource = Item.getAll();
        }

        private void Major_Load(object sender, EventArgs e)
        {

        }
    }
}
