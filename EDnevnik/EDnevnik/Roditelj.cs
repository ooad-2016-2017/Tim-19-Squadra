using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    public class Roditelj : Korisnik
    {
        private string brojTelefona;

        public string BrojTelefona
        {
            get { return brojTelefona; }
            set { brojTelefona = value; }
        }

        public Roditelj(string ime, string prezime, DateTime datumRodjenja, string mjestoRodjenja, string email, string username, string password, string brojTelefona)
            : base(ime, prezime, datumRodjenja, mjestoRodjenja, email, username, password)
        {
            BrojTelefona = brojTelefona;
        }
    }
}
