using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    public class Nastavnik : Korisnik
    {
        private List<Predmet> listaPredmeta;

        public List<Predmet> ListaPredmeta
        {
            get { return listaPredmeta; }
            set { listaPredmeta = value; }
        }
        public Nastavnik(string ime, string prezime, DateTime datumRodjenja, string mjestoRodjenja, string email, string username, string password, List<Predmet> predmeti)
            : base(ime, prezime, datumRodjenja, mjestoRodjenja, email, username, password)
        {
            ListaPredmeta = predmeti;
        }
    }
}
