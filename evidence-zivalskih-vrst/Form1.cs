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
            Kraji.ViewByKraj(labelByKraj, IDlistboxKraj);
        }

        private void listBoxVrste_SelectedIndexChanged(object sender, EventArgs e)
        {
            int IDlistboxVrsta = listBoxVrste.SelectedIndex + 1;

            Database Vrste = new Database();
            Vrste.ViewByVrste(labelByVrste, IDlistboxVrsta);
        }
    }
}
