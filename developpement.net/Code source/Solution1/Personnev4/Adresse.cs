using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace model
{
    class Adresse
    {
        private int numero;
        private string rue;
        private string cp;

        public Adresse(int numero, string rue, string cp)
        {
            this.numero = numero;
            this.rue = rue;
            this.cp = cp;
        }

        public int Numero
        {
            set
            {
                numero = value;
            }
        }

        public string Cp
        {
            get
            {
                return cp;
            }
        }

        public override string ToString()
        {
            return numero + "  " + rue + "  " + cp;
        }
    }
}
