using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_4_TessLarcade.Desk;
using static MegaDesk_4_TessLarcade.DeskQuote;

namespace MegaDesk_4_TessLarcade
{
    public partial class SearchQuotes : Form
    {

        public SearchQuotes()
        {
            InitializeComponent();
            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            searchMaterial.DataSource = DesktopMaterialList;

            string[] items = System.IO.File.ReadAllLines("quotes.txt");
            foreach (string item in items)
            {
                string[] logLine = item.Split(',');
                listView1.Items.Add(item);
            }

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
