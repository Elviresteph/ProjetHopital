using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TpImprimante
{
    class Program
    {
        static void Main()
        {
            Imprimante imprimante1 = new Imprimante("Imprimante1",true);
            Imprimante imprimante2 = new Imprimante("Imprimante2",true);
            //Imprimante imprimante3 = new Imprimante("Imprimante3", true);

            Poste poste1 = new Poste(1);
            Poste poste2 = new Poste(2);
            Poste poste3 = new Poste(3);

            List<Imprimante> listeImprimantes = new List<Imprimante> { imprimante1 , imprimante2};
            Centraliseur centraliseur = new Centraliseur(listeImprimantes);

 
            centraliseur.Print(poste1, "Document à imprimer");
            centraliseur.Print(poste2, "Document à imprimer2");
            centraliseur.active(imprimante1);
            centraliseur.Print(poste3, "Document à imprimer3");
        }
    }
}

