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
    public partial class Razredi : Form
    {
        public Razredi()
        {
            InitializeComponent();
        }

        private void Razredi_Load(object sender, EventArgs e)
        {
            Database Razredi = new Database();
            Razredi.ViewRazredi(listBoxRazredi);

            Database ViewSettings = new Database();
            ViewSettings.ViewSettings(labelFont, labelBackground);
            checkFonts();
        }

        private void Razredi_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDodajNaziv.Text))
            {
                MessageBox.Show("Izberite vse potrebne parametre!");
            }
            else
            {
                Razred novRazredPodatki = new Razred(textBoxDodajNaziv.Text);

                Database NovRazred = new Database();
                NovRazred.InsertRazred(novRazredPodatki);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDodajNaziv.Text) || listBoxRazredi.SelectedIndex <= -1)
            {
                MessageBox.Show("Izberite vse potrebne parametre!");
            }
            else
            {
                Razred updateRazredPodatki = new Razred(textBoxUpdateNaziv.Text);
                int IDlistbox = listBoxRazredi.SelectedIndex + 1;

                Database Razredi = new Database();
                Razredi.UpdateRazred(updateRazredPodatki, IDlistbox);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxRazredi.SelectedIndex <= -1)
            {
                MessageBox.Show("Izberite vse potrebne parametre!");
            }
            else
            {
                int IDlistbox = listBoxRazredi.SelectedIndex + 1;

                Database Razredi = new Database();
                Razredi.DeleteRazred(IDlistbox);
            }
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
            switch (labelBackground.Text)
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

        private void listBoxRazredi_SelectedIndexChanged(object sender, EventArgs e)
        {
            string splitdata = listBoxRazredi.Items[listBoxRazredi.SelectedIndex].ToString();
            string[] space = { " - " };
            string[] data = splitdata.Split(space, StringSplitOptions.RemoveEmptyEntries);

            textBoxUpdateNaziv.Text = data[0];
        }
    }
}
