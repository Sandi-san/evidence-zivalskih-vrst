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
        Form form1 = new Form1();

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
            Kraj novKrajPodatki = new Kraj(textBoxDodajIme.Text, textBoxDodajPosta.Text, textBoxDodajVelUporab.Text);

            Database NovKraj = new Database();
            NovKraj.InsertKraj(novKrajPodatki);
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            Kraj updateKrajPodatki = new Kraj(textBoxUpdateIme.Text, textBoxUpdatePosta.Text, textBoxUpdateVelUporab.Text);
            int IDlistbox = listBoxKraji.SelectedIndex + 1;

            Database Kraji = new Database();
            Kraji.UpdateKraj(updateKrajPodatki, IDlistbox);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int IDlistbox = listBoxKraji.SelectedIndex + 1;

            Database Kraji = new Database();
            Kraji.DeleteKraj(IDlistbox);
        }
    }
}
