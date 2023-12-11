using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using model;

namespace User
{
    class Program
    {
        static void Main(string[] args)
        {
            Test4();
        }
        static void Test4()
        {
            Adresse a1 = new Adresse(10, "rue de paris", "75012");
            Adresse a2 = new Adresse(100, "rue de Bordeaux", "75 000");
            Personne p1 = new Personne("a", "b", 10, a1);
            Console.WriteLine(p1);
            p1.Adr = a2;
            Console.WriteLine(p1);
        }
        //DEPUIS P1
        //on veut pouvoir modifier l age et le lire
        //on veut acceder au nom et prenom en lecture
        //on veut acceder en lecture au cp
        //on veut acceder en ecriture pour modifier numero de l adresse 

        static void Test3()
        {

            Adresse a1 = new Adresse(10, "rue de paris", "75012");
            Personne p1 = new Personne("a", "b", 10, a1);
            p1.Age = 15;
            Console.WriteLine(p1.Age);
            Console.WriteLine(p1.Nom);
            Console.WriteLine(p1.Prenom);

            Console.WriteLine(p1.Adr.Cp);
            Console.WriteLine(p1);
            p1.Adr.Numero = 11;
            Console.WriteLine("-----------------------");
            Console.WriteLine(p1);



        }
        static void Test2()
        {

            Adresse a1 = new Adresse(10, "rue de paris", "75012");
            Personne p1 = new Personne("a", "b", 10, a1);
            Console.WriteLine(p1);



        }
        static void Test1()
        {
            Personne p1 = new Personne("a", "b", 10);
            Adresse a1 = new Adresse(10, "rue de paris", "75012");
            Console.WriteLine(p1);
            Console.WriteLine(a1);

        }
    }
}

