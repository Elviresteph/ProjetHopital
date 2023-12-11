using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetDaoPersonne
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDelete();
        }
        static void TestDelete()
        {

            new DaoPersonne().Delete(10);

        }
        static void TestUpdate()
        {

            DaoPersonne dao = new DaoPersonne();
            // Personne p = new Personne(10, "aaa", "bbb", 30);
            Personne p = new Personne(10, "AAA", "BBB", 40);
            dao.Update(p);

        }
        static void TestInsert()
        {

            DaoPersonne dao = new DaoPersonne();
            Personne p = new Personne(10, "aaa", "bbb", 30);
            dao.Insert(p);




        }
        static void TestSelectById()
        {
            int id = 10;
            DaoPersonne dao = new DaoPersonne();
            Personne p = dao.SelectById(id);
            if (p != null)
                Console.WriteLine(p.Id + "\t" + p.Nom + "\t" + p.Prenom + "\t" + p.Age);
            else
                Console.WriteLine("personne  " + id + "  introuvable");




        }
        static void TestSelectAll()
        {
            DaoPersonne dao = new DaoPersonne();
            List<Personne> liste = dao.SelectAll();
            foreach (Personne p in liste)
                Console.WriteLine(p.Id + "\t" + p.Nom + "\t" + p.Prenom + "\t" + p.Age);

        }
    }
}
