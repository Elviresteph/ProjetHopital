using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Compte
    {
        private int numero;
        private double solde;
        private string banque;

        public Compte()
        {

        }

        public Compte(int numero, double solde, string banque)
        {
            this.numero = numero;
            this.solde = solde;
            this.banque = banque;

        }
        public string Banque
        {
            get
            {
                return banque;
            }
            set
            {
                banque = value;
            }
        }
        public double Solde
        {
            get
            {
                return solde;
            }
            set
            {
                solde = value;
            }
        }
        public int Numero
        {
            get
            {
                return numero;
            }
            set
            {
                numero = value;
            }
        }
        public override string ToString()
        {
            return this.numero + "   " + solde + "  " + banque;
        }
    }
}
