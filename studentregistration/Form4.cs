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
    public partial class TableLayout : Form
    {
        public TableLayout()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            foreach (var item in model.getAll())
            {
                customcard customcard = new customcard();
                customcard.ID = item.id;
                customcard.FIRSTNAME = item.fname;
                customcard.LASTNAME = item.lname;
                customcard.ADDRESS = item.address;
                customcard.SCHOOLYEAR = item.schoolYear;
                customcard.GENDER = item.gender;

                customcard.Click += (s, t) =>
                {
                    MessageBox.Show("Student clicked : " + item.fname + "" + item.lname);
                    //Registration f = new Registration();
                   // f.Show();
                };
                tableLayoutPanel1.Controls.Add(customcard);
            }


        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customcard1_Load(object sender, EventArgs e)
        {

        }
    }
}
