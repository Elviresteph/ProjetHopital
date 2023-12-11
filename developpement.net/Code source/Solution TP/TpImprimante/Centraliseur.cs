using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImprimante
{

    class Centraliseur
    {
        private List<Imprimante> listeImprimantes;

        public Centraliseur(List<Imprimante> imprimantes)
        {
            if (imprimantes.Count >= 1)
            {
                listeImprimantes = imprimantes;
            }
            else
            {
                Console.WriteLine("La liste d'imprimantes doit contenir au moins une imprimante.");
            }
        }

        public void Print(Poste poste, string document)
        {
            Imprimante imprimanteSelectionnee = listeImprimantes.Find(imprimante => imprimante.isActive == true);

            if (imprimanteSelectionnee != null)
            {
                string response = poste.Print(document) +" "+ imprimanteSelectionnee.Nom;

                Console.WriteLine(response);
                desable(imprimanteSelectionnee);
            }
            else
            {
                string response = poste.Print(document) + " " + "Aucune imprimante opérationnelle disponible.";
                Console.WriteLine(response);
            }
        }

        public void desable(Imprimante imprimante)
        {
            imprimante.isActive = false;
        }

        public void active(Imprimante imprimante)
        {
            imprimante.isActive = true;
        }
    }
}
