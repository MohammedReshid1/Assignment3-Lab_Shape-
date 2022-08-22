using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studentregistration
{
    public partial class customcard : UserControl
    {
        
        private string _id;

        public string ID
        {
            get { return _id; }
            set { _id = value; label13.Text = value; }
        }
        private string _firstname;

        public string FIRSTNAME
        {
            get { return _firstname; }
            set { _firstname = value; label7.Text = value; }
        }
        private string _lastname;

        public string LASTNAME
        {
            get { return _lastname; }
            set { _lastname = value; label8.Text = value; }
        }
        private string _address;

        public string ADDRESS
        {
            get { return _address; }
            set { _address = value; label9.Text = value; }
        }
        private string _schoolyear;

        public string SCHOOLYEAR
        {
            get { return _schoolyear; }
            set { _schoolyear = value; label10.Text = value; }
        }
        private string _gender;

        public string GENDER
        {
            get { return _gender; }
            set { _gender = value; label11.Text = value; }
        }
        public customcard()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void customcard_Load(object sender, EventArgs e)
        {

        }
    }
}
