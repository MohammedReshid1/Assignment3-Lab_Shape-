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
    public partial class StudentCustomCard : UserControl
    {
        private string _id;
        public string id
        { get { return _id; } set { _id = value; label7.Text = value; } }

        private string _fname;
        public string fname
        { get { return _fname; } set { _fname = value; label8.Text = value; } }

        private string _lname;
        public string lname
        { get { return _lname; } set { _lname = value; label9.Text = value; } }

        private string _address;
        public string address
        { get { return _address; } set { _address = value; label10.Text = value; } }

        private string _schoolYear;
        public string schoolYear
        { get { return _schoolYear; } set { _schoolYear = value;  } }

        private string _gender;
        public string gender
        { get { return _gender; } set { _gender = value; label11.Text = value; } }

        public StudentCustomCard()
        {
            InitializeComponent();
        }

        private void StudentCustomCard_Load(object sender, EventArgs e)
        {

        }
    }
}
