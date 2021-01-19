using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }
    }
}
