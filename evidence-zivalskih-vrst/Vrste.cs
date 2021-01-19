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
    public partial class Vrste : Form
    {
        public Vrste()
        {
            InitializeComponent();
        }

        private void Vrste_Load(object sender, EventArgs e)
        {
            Database Razredi = new Database();
            Razredi.ViewRazredi(listBoxDodajRazred);

            Database Vrste = new Database();
            Vrste.ViewVrsta(listBoxVrste);

            Database Kraji = new Database();
            Kraji.ViewKraji(listBoxDodajKraj);
        }

        private void Vrste_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            /*
            /*Doda Vrsto*
            Vrsta novaVrstaPodatki = new Vrsta(textBoxDodajIme.Text);

            int IDlistbox = listBoxDodajRazred.SelectedIndex + 1;

            Database Vrsta = new Database();
            Vrsta.InsertVrsta(novaVrstaPodatki, IDlistbox);

            /*Doda / posodobi povprečno št. (tabela kraj_vrste)*
            int IDlistboxKraja = listBoxDodajKraj.SelectedIndex + 1;
            int IDlistboxVrste = ;

            Database Povprecje = new Database();
            Povprecje.InsertPovprecje(IDlistboxKraja, IDlistboxVrste);
            */

            Vrsta novaVrstaPodatki = new Vrsta(textBoxDodajIme.Text);

            int IDlistboxRazred = listBoxDodajRazred.SelectedIndex + 1;
            int IDlistboxKraj = listBoxDodajKraj.SelectedIndex + 1;

            Database Vrsta = new Database();
            Vrsta.InsertVrsta(novaVrstaPodatki, IDlistboxRazred, IDlistboxKraj);
        }


    }
}
