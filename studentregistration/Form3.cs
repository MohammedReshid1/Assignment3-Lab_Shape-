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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            Registration screen = new Registration();
            screen.MdiParent = this;
            screen.Show();

        }

        private void displayAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            TableLayout screen = new TableLayout();
            screen.MdiParent = this;
            screen.Show();

        }
    }
}
