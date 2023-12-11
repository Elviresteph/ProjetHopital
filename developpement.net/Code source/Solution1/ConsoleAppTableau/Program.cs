using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTableau
{
    class Program
    {
        static void Main(string[] args)
        {
            TestSort();
        }
        static void TestSort()
        {
            int[] tab = { 50, 10, 20, 4, 5 };

            Affiche(tab);// 50 10 20 4 5
            //Sort(tab);
            Array.Sort(tab);
            Affiche(tab);// 4 5 10 20 50


        }

        static void Sort(int[] x)
        {
            //coder le trie
        }
        static void testSplit()
        {


            string str = "10;20;30;40;50";
            string[] tab = str.Split(';');
            Affiche(tab);

        }

        static void testSplitv2()
        {

            string str = "10;20;30 40*50";
            string[] tab = str.Split(';', ' ', '*');

            Affiche(tab);

        }

        static void TestDoublerTableauv2()
        {
            int[] tab1 = { 10, 20, 30, 40, 50 };

            Affiche(tab1);

            DoublerTableauv2(tab1);

            Affiche(tab1);


        }

        static void DoublerTableauv2(int[] x)
        {


            for (int i = 0; i < x.Length; i++)
                x[i] *= 2;


        }
        static void TestDoublerTableau()
        {
            int[] tab1 = { 10, 20, 30, 40, 50 };

            int[] tab2 = DoublerTableau(tab1);

            Affiche(tab1);
            Affiche(tab2);

        }


        static int[] DoublerTableau(int[] x)
        {

            int[] y = new int[x.Length];
            for (int i = 0; i < y.Length; i++)
                y[i] = x[i] * 2;
            return y;

        }

        static void Affiche(int[] x)
        {

            foreach (int e in x)
                Console.Write(e + "\t");
            Console.WriteLine();
        }
        static void TestTableauStringv2()
        {
            string[] tab = new string[4];
            tab[0] = "aaa";
            tab[1] = "bbb";
            tab[2] = "ccc";
            // tab[3] = "";

            foreach (string str in tab)
                if (str != null)
                    Console.Write(str.ToUpper() + "\t");




        }
        static void Affiche(string[] x)
        {

            foreach (string e in x)
                Console.Write(e + "\t");
            Console.WriteLine();
        }

        static void TestTableauString()
        {
            string[] tab1 = { "aa", "bb", "cc", "dd" };
            string[] tab2 = { "xx", "yy", "zz" };
            string[] tab3 = { "bonjour", "toto", "a bientot" };

            Affiche(tab1);

            Affiche(tab2);

            Affiche(tab3);


        }


        //    foreach(string str in tab2)
        //        Console.Write(str + "\t");
        //static void TestTableauString()
        //{
        //    string[] tab1 = { "aa", "bb", "cc", "dd" };
        //    string[] tab2 = { "xx", "yy", "zz" };

        //    for (int i = 0; i < tab1.Length; i++)
        //        Console.Write(tab1[i] + "\t");
        //    Console.WriteLine();
        //    for (int i = 0; i < tab2.Length; i++)
        //        Console.Write(tab2[i] + "\t");


        //}

        static void TestTableauIntv2()
        {

            int[] tab = new int[3];
            //valeur par defaut int:0  bool:false double:0 string:null
            Console.WriteLine(tab[0] + "\t" + tab[1] + "\t" + tab[2]);
            tab[0] = 10;
            tab[2] = 30;
            Console.WriteLine(tab[0] + "\t" + tab[1] + "\t" + tab[2]);



        }


        //Console.WriteLine("---------------------");
            //for (int i = 0; i< 3; i++)
                //Console.Write(tab[i]+"\t");


        static void TestTableauIntv1()
        {
            int[] tab = new int[3];
            //valeur par defaut int=0, bool=false, string=null, double=0
            Console.WriteLine(tab[0]);
            Console.WriteLine(tab[1]);
            Console.WriteLine(tab[2]);
        }
    }
}
