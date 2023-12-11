using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetTpCompte
{
    class compteCB : CompteSimple
    {
        CB cb;
        public compteCB(string titulaire, double solde,CB cb) : base(titulaire, solde)
        {
            this.cb = cb;
        }

        public override string ToString()
        {
            return base.ToString() + " " + "cb: " +" "+ cb;
        }

    }
    enum CB
    {
        VISA = 5,
        MC = 10,
        AMEX = 15
    }
}
