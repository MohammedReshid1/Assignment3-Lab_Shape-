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
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void newStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null) { 
                activeScreen.Close(); 
            }
            Form screen = new Form();
            screen.MdiParent = this;
            screen.Show();

        }

        private void updateStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var activeScreen = ActiveMdiChild;
            if (activeScreen != null)
            {
                activeScreen.Close();
            }
            DisplayAllProducts screen = new DisplayAllProducts();
            screen.MdiParent = this;
            screen.Show();

        }

        private void displayStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
