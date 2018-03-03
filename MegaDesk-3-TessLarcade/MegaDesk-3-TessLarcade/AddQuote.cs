using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_3_TessLarcade
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void Width_Validating(object sender, CancelEventArgs e)
        {
            string message = "Error: Width needs to be between 24 and 96 inches";
            if (width.Value < 96 && width.Value > 24)
            {
                e.Cancel = false;
            }
            else
                // Show message box
                MessageBox.Show(message);
            e.Cancel = true;

        }


        private void depth_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 48 && e.KeyChar >= 12)
            {
                MessageBox.Show("That depth is valid");
            }
            else
            {
                MessageBox.Show("Error: Depth needs to be between 12 and 48 inches");
            }
        }
    }
}
