using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetHopital
{
    class Medecin
    {
        private string nom;
        private int num_salle;
        private List<Patient> p;

        public Medecin(string nom, int num_salle, List<Patient> p)
        {
            this.nom = nom;
            this.num_salle = num_salle;
            this.p = p;
        }


    }
}
