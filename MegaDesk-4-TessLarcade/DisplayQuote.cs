using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_4_TessLarcade
{
    public partial class DisplayQuote : Form
    {
        /// <summary>
        /// 
        /// </summary>
        public DisplayQuote(string name, DateTime date, int width, int depth, int drawers, string material, int rushDays, int quoteTotal)
        {
            InitializeComponent();
            fullName.Text = name;
            quoteDate.Text = date.ToString();
            deskWidth.Text = width.ToString();
            deskDepth.Text = depth.ToString();
            deskDrawers.Text = drawers.ToString();
            deskMaterial.Text = material;
            rush.Text = rushDays.ToString();
            total.Text = quoteTotal.ToString();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            MainMenu mainMenu = new MainMenu();
            mainMenu.Tag = this;
            mainMenu.Show(this);
            Hide();
        }
    }
}
