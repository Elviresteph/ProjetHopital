using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImprimante
{
    class Poste
    {
        public int numeros;
        public Imprimante I;

        public Poste(int numeros)
        {
            this.numeros = numeros;        
        }

        public string Print(string document)
        {
            string response = "le poste: " + numeros+ " " + document ;
            return response;
        }
    }
}
