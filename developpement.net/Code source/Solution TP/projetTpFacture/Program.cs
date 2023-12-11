using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpFacture
{
    class Program
    {
        static void Main(string[] args)
        {
            TpFacture();
        }
        static void TpFacture()
        {
            List<Ligne> lignes = new List<Ligne>();
            Facture f = new Facture(lignes,"Jacky");

            Boisson b1 = new Boisson("coca", 2, Eboisson.grand);
            Gateau g1 = new Gateau("LU", 4, EGateau.choco);
            Boisson b2 = new Boisson("orangina", 3, Eboisson.grand);
            Gateau g2 = new Gateau("cake", 7, EGateau.vanille);
            Ligne l1 = new Ligne(b1, 3);
            Ligne l2 = new Ligne(g1, 1);
            Ligne l3 = new Ligne(g2, 2);
            Ligne l4 = new Ligne(b2, 3);

            f.ajouter(l1);
            f.ajouter(l2);
            f.ajouter(l3);
            f.ajouter(l4);

            Console.WriteLine(f.ToString());


        }
    }
}
