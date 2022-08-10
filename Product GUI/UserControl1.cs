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
    public partial class UserControl1 : UserControl
    {
        private string _title;
        public string Title
        { get { return _title; } set { _title = value; label1.Text = value; } }


        public UserControl1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
