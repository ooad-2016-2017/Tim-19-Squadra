using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDnevnik
{
    // Container klasa
    public class EDnevnik
    {
        private List<Nastavnik> nastavnici;

        public List<Nastavnik> Nastavnici
        {
            get { return nastavnici; }
            set { nastavnici = value; }
        }
        private List<Ucenik> ucenici;

        public List<Ucenik> Ucenici
        {
            get { return ucenici; }
            set { ucenici = value; }
        }
    }
}
