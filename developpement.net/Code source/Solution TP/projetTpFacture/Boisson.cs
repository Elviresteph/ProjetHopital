using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpFacture
{
    class Boisson : abstract_Article
    {
        Eboisson eboisson;

        public Boisson(string nom, double prix, Eboisson eboisson) : base(nom, prix)
        {
            this.eboisson = eboisson;
        }

        public override string ToString()
        {
            return "boisson " + base.ToString() + " - " + eboisson + ": " + (int)eboisson + " litres";
        }
    }
    enum Eboisson
    {
        petit = 1,
        moyen = 2,
        grand = 3
    }
}
