﻿using System;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddQuote addNewQuote = new AddQuote();
            addNewQuote.Tag = this;
            addNewQuote.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewAllQuotes viewQuote = new ViewAllQuotes();
            viewQuote.Tag = this;
            viewQuote.Show(this);
            Hide();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
            SearchQuotes searchQuote = new SearchQuotes();
            searchQuote.Tag = this;
            searchQuote.Show(this);
            Hide();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
