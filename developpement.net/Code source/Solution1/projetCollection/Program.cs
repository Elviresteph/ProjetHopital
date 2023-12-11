using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            Test7();
        }
        static void Test7()
        {

            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico.Add("aa", "06254784");
            dico.Add("bb", "123456");
            dico.Add("cc", "012542544");

            Console.WriteLine("choisir depuis la liste:");

            ICollection<string> cle = dico.Keys;
            foreach (string e in cle)
                Console.Write(e + "\t");

            string saisie = Console.ReadLine().ToLower();

            Console.WriteLine(dico[saisie]);


        }
        static void Test6()
        {

            Dictionary<string, string> dico = new Dictionary<string, string>();
            dico.Add("aa", "06254784");
            dico.Add("bb", "06254784");
            dico.Add("cc", "012542544");
            dico.Add("dd", null);

            string result = dico["cc"];
            Console.WriteLine(result);


        }
        static void Test5()
        {
            Queue<Employe> file = new Queue<Employe>();
            file.Enqueue(new Employe("aa", "aa", 10));
            file.Enqueue(new Employe("bb", "bb", 10));
            file.Enqueue(new Employe("cc", "cc", 10));

            foreach (Employe e in file)
                Console.WriteLine(e);

            Console.WriteLine("-------------------------------");
            Employe x = file.Dequeue();
            Console.WriteLine("sortie de la personne  " + x);
            Console.WriteLine("-------------------------------");
            foreach (Employe e in file)
                Console.WriteLine(e);
            Console.WriteLine("-------------------------------");
            Employe y = file.Peek();
            Console.WriteLine(y);
            Console.WriteLine("-------------------------------");
            foreach (Employe e in file)
                Console.WriteLine(e);

            //peek personne succeptible de sortir
            //count noter le nbe d'element
        }
        static void Test3()
        {
            Queue<Employe> file = new Queue<Employe>();
            file.Enqueue(new Employe("aa", "aa", 10));
            file.Enqueue(new Employe("bb", "bb", 10));
            file.Enqueue(new Employe("cc", "cc", 10));

            foreach (Employe e in file)
                Console.WriteLine(e);


        }
        static void Test2()
        {


            List<string> liste = new List<string>(10);
            liste.Add("toto");
            Console.WriteLine(liste.Capacity);
            Console.WriteLine(liste.Count);



        }
        static void Test1()
        {

            List<int> liste1 = new List<int>();
            List<string> liste2 = new List<string>();

            liste1.Add(10);
            liste1.Add(20);
            liste1.Add(30);
            liste1.Add(40);

            foreach (int e in liste1)
                Console.Write(e + "\t");

        }

    }
}
