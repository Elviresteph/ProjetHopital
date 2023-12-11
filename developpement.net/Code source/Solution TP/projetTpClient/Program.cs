using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            tpClient();
        } 
        static void tpClient()
        {
            Adresse A1 = new Adresse("4 rue du capitaine Bastien", "Melun", "France");   
            Compte C1 = new Compte(1258654252, 9000, "Poste");
            Client clientAvec  = new Client("Dupont", "toto", A1, C1);
      
            clientAvec.Nom = "Elvire";
            A1.Rue = "3 rue de l'abreuvoir";
            clientAvec.Compte.Solde = 100000;
            clientAvec.Compte.Numero = 1000002;
            clientAvec.Compte.Banque = "Bousourama";    
            Console.WriteLine(clientAvec.ToString());
            Console.WriteLine("-------------------");
            Client clientSans = new Client("Dupont", "titi", A1);
            Console.WriteLine(clientSans.ToString());
        }
    }
}
