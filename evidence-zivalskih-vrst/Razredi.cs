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
    }
}
