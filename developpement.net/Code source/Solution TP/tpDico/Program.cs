using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpDico
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Personne> dico = new Dictionary<string, Personne>();
            Personne p1 = new Personne("Doungue", "Elvire", "5 rue du lion", "0730298714");
            Personne p2 = new Personne("Doungue2", "Elvire2", "10 allé du chat", "0730298715");
            Personne p3 = new Personne("Doungue3", "Elvire3", "15 rue du chien", "0730298716");
            Personne p4 = new Personne("Doungue4", "Elvire4", "55 boulevard des papillons", "0730298717");

            dico.Add(p1.telephone, p1);
            dico.Add(p2.telephone, p2);
            dico.Add(p3.telephone, p3);
            dico.Add(p4.telephone, p4);

            ICollection<string> cle = dico.Keys;
            foreach (string e in cle)
                Console.Write(e + "\t");

            Console.Write("\n choisir un telephone depuis la liste\t");
            string saisie = Console.ReadLine().ToLower();

            Console.WriteLine(dico[saisie]);
        }
    }
}
