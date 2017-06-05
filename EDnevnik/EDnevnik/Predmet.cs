using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    public class Predmet
    {
        private string naziv;

        public string Naziv
        {
            get { return naziv; }
            set { naziv = value; }
        }
        private int brojCasova;

        public int BrojCasova
        {
            get { return brojCasova; }
            set { brojCasova = value; }
        }
        private string opisPredmeta;

        public string OpisPredmeta
        {
            get { return opisPredmeta; }
            set { opisPredmeta = value; }
        }
        private string literatura;

        public string Literatura
        {
            get { return literatura; }
            set { literatura = value; }
        }
        public Predmet(string naziv, int brojCasova, string opis, string literatura)
        {
            Naziv = naziv;
            BrojCasova = brojCasova;
            OpisPredmeta = opis;
            Literatura = literatura;
        }
    }
}
