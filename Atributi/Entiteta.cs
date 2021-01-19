using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atributi
{
    public class Kraj
    {
        public string ImeKraja { get; set; }
        public string CifraKraja { get; set; }
        public string VelikiUporabnik { get; set; }
        /*
        private string _velikiuporabnik;
        public string VelikiUporabnik 
        { 
            get
            {
                return _velikiuporabnik;
            }
            
            set
            {
                
                if (value == null)
                {
                    _velikiuporabnik = null;
                }
            }
        
        }
        */

        public Kraj()
        {

        }

        public Kraj(string ime, string posta, string velupor)
        {
            ImeKraja = ime;
            CifraKraja = posta;
            VelikiUporabnik = velupor;
        }
    }

    public class Razred
    {
        public string NazivRazreda { get; set; }

        public Razred()
        {

        }

        public Razred(string naziv)
        {
            NazivRazreda = naziv;
        }
    }

    public class Vrsta : Razred
    {
        public string ImeVrste { get; set; }

        public Vrsta()
        {

        }

        public Vrsta(string ime)
        {
            ImeVrste = ime;
        }

        public Vrsta(string naziv, string ime) : base(naziv)
        {
            NazivRazreda = naziv; //vzame od nadrazreda
            ImeVrste = ime;
        }
    }
}
