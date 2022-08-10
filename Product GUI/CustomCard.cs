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
    public partial class CustomCard : UserControl
    {
        private string _Title;

        public string Title
        {
            get { return _Title; }
            set { _Title = value;
                lbl_Title.Text = value;}
            
        }
        private string _Description;

        public string Description
        {
            get { return _Description; }
            set { _Description = value;
                lbl_Description.Text = value;
            }

        }
        private string _Price;

        public string Price
        {
            get { return _Price; }
            set { _Price = value;
                lbl_Price.Text = value;
            }

        }


        public CustomCard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CustomCard_Load(object sender, EventArgs e)
        {

        }
    }
}
