using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpCommande
{
    class Commande
    {
        string client;
        Boisson b;
        Plat p;
        Dessert d;

        public Commande(string client, Boisson boisson, Plat plat, Dessert dessert)
        {
        this.client = client;
            b = boisson;
            p = plat;
            d = dessert;
        }
        public int GetGlobalPrix()
        {
            return (int)b + (int)p + (int)d;
        }
        public override string ToString()
        {
            return client + "\n" + b + " " + (int)b + "\n" + p + " " + (int)p + "\n" + d + " " + (int)d + "\n\t\t" + GetGlobalPrix() + "dollar";
        }

    }
 }
