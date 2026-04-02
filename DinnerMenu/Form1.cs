using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerMenu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Centers all text within the menu text box
            MenuTextBox.SelectionAlignment = HorizontalAlignment.Center;
        }

        private void saladButton_Click(object sender, EventArgs e)
        {
            MenuTextBox.Text = "Cesar Salad with pepperchini's.";
        }

        private void soupButton_Click(object sender, EventArgs e)
        {
            MenuTextBox.SelectionAlignment = HorizontalAlignment.Center;
            MenuTextBox.Text = "Beef Soup straight from the can";
        }

        private void pastaButton_Click(object sender, EventArgs e)
        {
            MenuTextBox.Text = "Chiken or Shrimp Alfredo";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Closes program
            this.Close();
        }
    }
}
