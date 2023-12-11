using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            TestPrint();
        }
        static void TestPrint()
        {
            Print();

            Print("aa", 10);
            Print(10, "aa");

            Print("toto");//2
                          //  string str= Print("toto");//6


        }

        //1
        static void Print()
        {
            Console.WriteLine("coucou");

        }
        ////2.overloader surcharge de methodes
        static void Print(string nom)
        {
            Console.WriteLine("coucou NOM:" + nom);
        }

        // 2 vs 6

        //6.
        //static string Print(string x)
        //{
        //    Console.WriteLine("coucou x:" + x);
        //    return "a bientot";
        //}

        //3
        static void Print(int a)
        {
            Console.WriteLine("coucou :" + a);
        }
        // 3 bis
        //static void Print(string x)
        //{
        //    Console.WriteLine("coucou NOM:" + x);
        //}

        //4
        static void Print(string a, int b)
        {
            Console.WriteLine("coucou " + a + "   " + b);
        }
        //5
        static void Print(int a, string b)
        {
            Console.WriteLine("coucou " + a + "   " + b);
        }
            //static void TestPrint1()
            //{
            //    print();
            //    print();
            //    print();
            //    print("toto");
            //}
            //static void print()
            //{
            //    //1
            //    static void Print()
            //{
            //    Console.WriteLine("coucou");

            //}
            ////2.overloader surcharge de methodes
            //static void Print(string nom)
            //{
            //    Console.WriteLine("coucou NOM:" + nom);
            //}

            ////3
            //static void Print(int a)
            //{
            //    Console.WriteLine("coucou :" + a);
            //}
            //// 3 bis
            ////static void Print(string x)
            ////{
            ////    Console.WriteLine("coucou NOM:" + x);
            ////}

            ////4
            //static void Print(string a, int b)
            //{
            //    Console.WriteLine("coucou " + a + "   " + b);
            //}
            ////5
            //static void Print(int a, string b)
            //{
            //    Console.WriteLine("coucou " + a + "   " + b);
            //}


            ////static void TestPrint()
            ////{
            ////    print();
            ////    print();
            ////    print();
            ////    print("toto");
            ////}
            ////static void print()
            ////{
            ////    Console.WriteLine("coucou");
            ////}
            ////static void print(string nom)
            ////{
            ////    Console.WriteLine("coucou" +nom);
            //}

            //static void Print(string a, int b)
            //{
            //    Console.WriteLine("coucou " + a + "   " + b);
            //}
            //static void Print(int a, string b)
            //{
            //    Console.WriteLine("coucou " + a + "   " + b);
            //}

        }
}
