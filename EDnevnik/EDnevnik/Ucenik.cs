using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    public class Ucenik : Korisnik
    {
        private int razred;

        public int Razred
        {
            get { return razred; }
            set { razred = value; }
        }
        private int odjeljenje;

        public int Odjeljenje
        {
            get { return odjeljenje; }
            set { odjeljenje = value; }
        }
        private int brojUDnevniku;

        public int BrojUDnevniku
        {
            get { return brojUDnevniku; }
            set { brojUDnevniku = value; }
        }
        public Ucenik(string ime, string prezime, DateTime datumRodjenja, string mjestoRodjenja, string email, string username, string password, int razred, int odjeljenje, int brojUDnevniku)
            : base(ime, prezime, datumRodjenja, mjestoRodjenja, email, username, password)
        {
            Razred = razred;
            Odjeljenje = odjeljenje;
            BrojUDnevniku = brojUDnevniku;
        }
    }
}
