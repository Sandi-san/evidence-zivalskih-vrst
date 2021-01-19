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
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            Vrsta novaVrstaPodatki = new Vrsta(textBoxDodajIme.Text);

            int IDlistbox = listBoxDodajRazred.SelectedIndex + 1;

            Database Vrsta = new Database();
            Vrsta.InsertVrsta(novaVrstaPodatki, IDlistbox);
        }
    }
}
