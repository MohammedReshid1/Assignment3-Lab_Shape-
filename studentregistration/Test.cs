using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace studentregistration
{
    public partial class Test : Form
    {





        public Test()
        {
            InitializeComponent();
        }

        private void Test_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = MOAMMEDS-SURFAC\SQLEXPRESS; Initial catalog = Lab7 ; Integrated Security = True";
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                con.Open();
                MessageBox.Show("Connected");
                String query = "select* from personsss";
                SqlCommand com= new SqlCommand(query, con);
                //execute non query inserted(rows affected will be returned)
                //execute scalar() single element will be returned
                //execute reader sql result will be returned
                var rowsaffected = com.ExecuteReader();
                while (rowsaffected.Read())
                {
                    string name = (string)rowsaffected[0];
                    string Country = (string)rowsaffected[1];
                    MessageBox.Show(name + " " + Country);

                 
                }
            }
            catch(Exception )
            {
                MessageBox.Show("Not Connected");
            }


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

        }
    }    

}

