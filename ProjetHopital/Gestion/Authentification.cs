using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestions
{
    public class Authentification
    {
        public string login;
        public string password;
        public string nom;
        public int metier;

        public Authentification(string login, string password)
        {
            this.login = login;
            this.password = password;
        }

        public Authentification(string login, string password, string nom, int metier)
        {
            this.login = login;
            this.password = password;
            this.nom = nom;
            this.metier = metier;
        }

        public override string ToString()
        {
            return login + "    " + password;
        }
    }
}
