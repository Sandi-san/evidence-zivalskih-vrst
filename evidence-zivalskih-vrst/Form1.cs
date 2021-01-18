﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Atributi; //referenca z Atributi

namespace evidence_zivalskih_vrst
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonKrajForm_Click(object sender, EventArgs e)
        {
            NovKraj odpriNovKraj = new NovKraj();
            odpriNovKraj.Show();

            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database ListKraji = new Database();
            ListKraji.ViewKraji(listBoxKraji);

            Database ListRazredi = new Database();
            ListRazredi.ViewRazredi(listBoxRazredi);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void buttonRazredForm_Click(object sender, EventArgs e)
        {
            Razredi odpriRazrede = new Razredi();
            odpriRazrede.Show();

            this.Hide();
        }
    }
}
