using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    public class Napomena
    {
        private DateTime datumNapomene;

        public DateTime DatumNapomene
        {
            get { return datumNapomene; }
            set { datumNapomene = value; }
        }

        private string tekstNapomene;

        public string TekstNapomene
        {
            get { return tekstNapomene; }
            set { tekstNapomene = value; }
        }
        private List<Ucenik> listaZapisanihUcenika;

        public List<Ucenik> ListaZapisanihUcenika
        {
            get { return listaZapisanihUcenika; }
            set { listaZapisanihUcenika = value; }
        }

        private Nastavnik napomenuSastavio;

        public Nastavnik NapomenuSastavio
        {
            get { return napomenuSastavio; }
            set { napomenuSastavio = value; }
        }

    }
}
