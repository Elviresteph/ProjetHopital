using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDico
{
    class Complement
    {
        public string adresse;
        public string telephone;

        public Complement(string adresse, string telephone)
        {
            this.adresse = adresse;
            this.telephone = telephone;

        }

        public override string ToString()
        {
            string res = "adresse: " + adresse + "\t" + "telephone: " + telephone;

            return res;
        }
    }
}
