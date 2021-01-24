using System;
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

            Database ListVrste = new Database();
            ListVrste.ViewVrsta(listBoxVrste);

            Database ViewSettings = new Database();
            ViewSettings.ViewSettings(labelFont, labelBackground);
            checkFonts();
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

        private void buttonVrsteForm_Click(object sender, EventArgs e)
        {
            Vrste odpriVrste = new Vrste();
            odpriVrste.Show();

            this.Hide();
        }

        private void listBoxKraji_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDlistboxKraj = listBoxKraji.SelectedIndex + 1;

            Database Kraji = new Database();
            Kraji.ViewByKraj(labelByKraj, IDlistboxKraj, chart1);
        }

        private void listBoxVrste_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDlistboxVrsta = listBoxVrste.SelectedIndex + 1;

            Database Vrste = new Database();
            Vrste.ViewByVrste(labelByVrste, IDlistboxVrsta, chart1);
        }

        private void buttonSettings_Click(object sender, EventArgs e)
        {
            Barve odpriBarve = new Barve();
            odpriBarve.Show();

            this.Hide();
        }

        public void checkFonts()
        {
            switch (labelFont.Text)
            {
                case "white":
                    this.BackColor = Color.White;
                    break;
                case "black":
                    this.BackColor = Color.Black;
                    break;
                case "gray":
                    this.BackColor = Color.Gray;
                    break;
                case "grey":
                    this.BackColor = Color.Gray;
                    break;
                case "red":
                    this.BackColor = Color.Red;
                    break;
                case "orange":
                    this.BackColor = Color.Orange;
                    break;
                case "yellow":
                    this.BackColor = Color.Yellow;
                    break;
                case "green":
                    this.BackColor = Color.Green;
                    break;
                case "blue":
                    this.BackColor = Color.Blue;
                    break;
                case "purple":
                    this.BackColor = Color.Purple;
                    break;
                case "brown":
                    this.BackColor = Color.Brown;
                    break;
                case "magenta":
                    this.BackColor = Color.Magenta;
                    break;
                case "tan":
                    this.BackColor = Color.Tan;
                    break;
                case "cyan":
                    this.BackColor = Color.Cyan;
                    break;
                case "olive":
                    this.BackColor = Color.Olive;
                    break;
                case "maroon":
                    this.BackColor = Color.Maroon;
                    break;
                case "navy":
                    this.BackColor = Color.Navy;
                    break;
                case "aquamarine":
                    this.BackColor = Color.Aquamarine;
                    break;
                case "turquoise":
                    this.BackColor = Color.Turquoise;
                    break;
                case "silver":
                    this.BackColor = Color.Silver;
                    break;
                case "lime":
                    this.BackColor = Color.Lime;
                    break;
                case "teal":
                    this.BackColor = Color.Teal;
                    break;
                case "indigo":
                    this.BackColor = Color.Indigo;
                    break;
                case "violet":
                    this.BackColor = Color.Violet;
                    break;
                case "pink":
                    this.BackColor = Color.Pink;
                    break;
            }
            switch(labelBackground.Text)
            {
                case "white":
                    this.ForeColor = Color.White;
                    break;
                case "black":
                    this.ForeColor = Color.Black;
                    break;
                case "gray":
                    this.ForeColor = Color.Gray;
                    break;
                case "grey":
                    this.ForeColor = Color.Gray;
                    break;
                case "red":
                    this.ForeColor = Color.Red;
                    break;
                case "orange":
                    this.ForeColor = Color.Orange;
                    break;
                case "yellow":
                    this.ForeColor = Color.Yellow;
                    break;
                case "green":
                    this.ForeColor = Color.Green;
                    break;
                case "blue":
                    this.ForeColor = Color.Blue;
                    break;
                case "purple":
                    this.ForeColor = Color.Purple;
                    break;
                case "brown":
                    this.ForeColor = Color.Brown;
                    break;
                case "magenta":
                    this.ForeColor = Color.Magenta;
                    break;
                case "tan":
                    this.ForeColor = Color.Tan;
                    break;
                case "cyan":
                    this.ForeColor = Color.Cyan;
                    break;
                case "olive":
                    this.ForeColor = Color.Olive;
                    break;
                case "maroon":
                    this.ForeColor = Color.Maroon;
                    break;
                case "navy":
                    this.ForeColor = Color.Navy;
                    break;
                case "aquamarine":
                    this.ForeColor = Color.Aquamarine;
                    break;
                case "turquoise":
                    this.ForeColor = Color.Turquoise;
                    break;
                case "silver":
                    this.ForeColor = Color.Silver;
                    break;
                case "lime":
                    this.ForeColor = Color.Lime;
                    break;
                case "teal":
                    this.ForeColor = Color.Teal;
                    break;
                case "indigo":
                    this.ForeColor = Color.Indigo;
                    break;
                case "violet":
                    this.ForeColor = Color.Violet;
                    break;
                case "pink":
                    this.ForeColor = Color.Pink;
                    break;
            }
        }
    }
}
