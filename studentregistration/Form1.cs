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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addbutton_Click(object sender, EventArgs e)
        {
            model m = new model();

            //bool flag = false;
            m.id = textBoxid.Text;
                m.fname = textBoxfname.Text;
                m.lname = textBoxlname.Text;
                m.address = textBoxaddress.Text;
                m.schoolYear = dateTimePicker1.Text;
                if (radioButtonmale.Checked==true)
                    m.gender = radioButtonmale.Text;
                else
                    m.gender = radioButtonfemale.Text;
            m.save();

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = model.getAll();

            /*  if (textBoxid.Text.Length < 1)
              {
                  errorProvider1.SetError(textBoxid,"Cannot be Empty"); 

              }
              //Checks if the Object name is given  
              else if (string.IsNullOrEmpty(textBoxfname.Text) || string.IsNullOrEmpty(textBoxlname.Text))
              {
                  errorProvider1.SetError(textBoxfname, "Name is required");
              }
              //Checks if count is entered
              else if (radioButtonfemale.Checked == false)
              {

                  if (radioButtonmale.Checked == false)
                  {
                      errorProvider1.SetError(radioButtonmale, "PLEASE SELECT GENDER");
                  }


              }
              else
              {
                  errorProvider1.Clear();
                  flag = true;
              }

              //Validate if Object name starts with characters 
              //if (!(regex.IsMatch(txt_objectname.Text)))
              //{ 
              //    MessageBox.Show("Object name must start with characters");
              //}


              if (flag==true)
              {
                  dataGridView1.DataSource= null;
                  dataGridView1.DataSource = model.getAll();
                  MessageBox.Show("STUDENT SAVED");
              }*/
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxid.Clear();
            textBoxaddress.Clear();
            textBoxlname.Clear();
            textBoxfname.Clear();
            radioButtonfemale.Checked = false;
            radioButtonmale.Checked = false;
            dateTimePicker1 = new System.Windows.Forms.DateTimePicker();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

