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

namespace MegaDesk_4_TessLarcade
{
    public partial class AddQuote : Form
    {
        string Name = String.Empty;
        int DeskWidth = 0;
        int DeskDepth = 0;
        int Drawers = 0;
        int RushDays = 0;
        DesktopMaterial DesktopMaterial;
        int quoteTotal = 0;

        public AddQuote()
        {
            InitializeComponent();

            List<DesktopMaterial> DesktopMaterialList = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            desktopCombo.DataSource = DesktopMaterialList;
        }

        private void Back_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            int width = Convert.ToInt32(widthInput.Text);
            string message = "Error: Width needs to be between 24 and 96 inches";
            if (width <= MAXWIDTH && width >= MINDEPTH)
            {
                return;
            }
            else
            {
                // Show message box
                widthInput.Text = String.Empty;
                MessageBox.Show(message);
            }
        }
        private void Depth_Validating(object sender, CancelEventArgs e)
        {
            int depth = Convert.ToInt32(depthInput.Text);
            string message = "Error: Depth needs to be between 12 and 48 inches";
            if (depth <= MAXDEPTH && depth >= MINDEPTH)
            {
                return;
            }
            else
            {
                // Show message box
                depthInput.Text = String.Empty;
                MessageBox.Show(message);
            }
        }
        private void valid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
        public void submit_Click(object sender, EventArgs e)
        {
            try
            {
                Name = namebox.Text;
                DeskWidth = int.Parse(widthInput.Text);
                DeskDepth = int.Parse(depthInput.Text);
                Drawers = int.Parse(drawersCombo.SelectedItem.ToString());
                string Material = desktopCombo.SelectedItem.ToString();
                Enum.TryParse(Material, out DesktopMaterial);


                if (rush3.Checked)
                {
                   RushDays = 3;
                }
                if (rush5.Checked)
                {
                    RushDays = 5;
                }
                if (rush7.Checked)
                {
                    RushDays = 7;
                }

                DeskQuote NewQuote = new DeskQuote(DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushDays);
                quoteTotal = NewQuote.quoteTotal();
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Check input methods");
                throw;
            }

            DeskQuote newQuote = new DeskQuote(DeskWidth, DeskDepth, Drawers, DesktopMaterial, RushDays);

            quoteTotal = newQuote.quoteTotal();

            try
            {
                var DeskRecord = Name + ", " + DateTime.Now.Date + ", " + DeskWidth + ", " +
                   DeskDepth + ", " + Drawers + ", " + DesktopMaterial + ", " + RushDays;

                string cFile = @"quotes.txt";
                if (!System.IO.File.Exists(cFile))
                {
                    using (System.IO.StreamWriter sw = System.IO.File.CreateText("quotes.txt"))
                    {
                    }
                    using (System.IO.StreamWriter sw = System.IO.File.AppendText("quotes.txt"))
                    {
                        sw.WriteLine(DeskRecord);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Unable to create file");
                throw;
            }

            var mainMenu = (MainMenu)Tag;
            DisplayQuote newView = new DisplayQuote(Name, DateTime.Now.Date, DeskWidth, DeskDepth, Drawers, DesktopMaterial.ToString(), RushDays, quoteTotal);
            {
                Tag = mainMenu;
            };
            newView.Show();
            Hide();

        }
    }
}
