using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImprimante
{
    class Imprimante
    {
        public string Nom { get; private set; }
        public bool isActive { get; set; } = true;
      

        public Imprimante(string nom, bool IsActive)
        {
            Nom = nom;
            IsActive = isActive;
        }
    }
}
