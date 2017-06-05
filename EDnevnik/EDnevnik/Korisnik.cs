using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    public class Korisnik
    {
        private string ime;

        public string Ime
        {
            get { return ime; }
            set { ime = value; }
        }
        private string prezime;

        public string Prezime
        {
            get { return prezime; }
            set { prezime = value; }
        }
        private DateTime datumRodjenja;

        public DateTime DatumRodjenja
        {
            get { return datumRodjenja; }
            set { datumRodjenja = value; }
        }
        private string mjestoRodjenja;

        public string MjestoRodjenja
        {
            get { return mjestoRodjenja; }
            set { mjestoRodjenja = value; }
        }
        private string email;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        private string username;

        public string Username
        {
            get { return username; }
            set { username = value; }
        }
        private string password;

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public Korisnik(string ime, string prezime, DateTime datumRodjenja, string mjestoRodjenja, string email, string username, string password)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;
            MjestoRodjenja = mjestoRodjenja;
            Email = email;
            Username = username;
            Password = password;
        }

    }
}
