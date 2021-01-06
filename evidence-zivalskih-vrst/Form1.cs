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

        private void buttonKrajNov_Click(object sender, EventArgs e)
        {
            Kraj novKrajPodatki = new Kraj(textBoxKrajIme.Text, textBoxKrajPosta.Text, textBoxKrajVelUporab.Text);

            Database NovKraj = new Database();
            NovKraj.NovKraj(novKrajPodatki);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database Kraji = new Database();
            Kraji.ViewKraji(listBoxKraji);
        }
    }
}
