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
    public partial class NovKraj : Form
    {
        public NovKraj()
        {
            InitializeComponent();
        }

        private void NovKraj_Load(object sender, EventArgs e)
        {
            Database Kraji = new Database();
            Kraji.ViewKraji(listBoxKraji);
        }

        private void NovKraj_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();

            this.Hide();
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDodajIme.Text) || String.IsNullOrEmpty(textBoxDodajPosta.Text) || String.IsNullOrEmpty(textBoxDodajVelUporab.Text))
            {
                MessageBox.Show("Izberite vse potrebne parametre!");
            }
            else
            {
                Kraj novKrajPodatki = new Kraj(textBoxDodajIme.Text, textBoxDodajPosta.Text, textBoxDodajVelUporab.Text);

                Database NovKraj = new Database();
                NovKraj.InsertKraj(novKrajPodatki);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBoxDodajIme.Text) || String.IsNullOrEmpty(textBoxDodajPosta.Text) || String.IsNullOrEmpty(textBoxDodajVelUporab.Text) || listBoxKraji.SelectedIndex <= -1)
            {
                MessageBox.Show("Izberite vse potrebne parametre!");
            }
            else
            {
                Kraj updateKrajPodatki = new Kraj(textBoxUpdateIme.Text, textBoxUpdatePosta.Text, textBoxUpdateVelUporab.Text);
                int IDlistbox = listBoxKraji.SelectedIndex + 1;

                Database Kraji = new Database();
                Kraji.UpdateKraj(updateKrajPodatki, IDlistbox);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (listBoxKraji.SelectedIndex <= -1)
            {
                MessageBox.Show("Izberite vse potrebne parametre!");
            }
            else
            {
                int IDlistbox = listBoxKraji.SelectedIndex + 1;

                Database Kraji = new Database();
                Kraji.DeleteKraj(IDlistbox);
            }
        }
    }
}
