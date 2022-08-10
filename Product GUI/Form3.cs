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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void customCard1_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var item in Item.getAll())
            {
                CustomCard customCard = new CustomCard();
                customCard.Title = item.ToString();
                customCard.Description = item.ToString();
                customCard.Price = item.ToString();
                flowLayoutPanel1.Controls.Add(customCard);  
            }
        }
    }
}
