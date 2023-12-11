using System;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            TpRandomv2();
        }
        static void TpRandomv2()
        {
            Random r = new Random();
            int nb = r.Next(1, 10);
            Console.WriteLine(nb);

            int compteur = 0;
            do
            {
                Console.WriteLine("saisir nombre");
                compteur++;

            }
            while (nb != Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("trouvé en " + compteur + " coups");
        }
        static void TestRandom()
        {
            Random r = new Random();
            int nb = r.Next(1, 10);
            Console.WriteLine(nb);


        }
        static void TestDoWhilev3()
        {

            int i = 0;

            bool b = false;
            do
            {
                i++;
                if (i == 5) b = true;
                Console.Write(".");
            }
            while (!b);

            Console.WriteLine("\nFin!");

        }
        static void TestDoWhilev2()
        {

            int i = 0;

            bool boucle = true;
            do
            {
                i++;
                if (i == 5) boucle = false;
                Console.Write(".");
            }
            while (boucle == true);

            Console.WriteLine("\nFin!");

        }
        static void TestDoWhile()
        {

            int i = 100;
            const int MAX = 10;
            do
            {
                i++;
                Console.Write(".");
            }
            while (i < MAX);
            Console.WriteLine("\nFin!");

        }

        static void TestWhile()
        {
            int i = 0;
            const int MAX = 10;
            while (i < MAX)
            {
                i++;
                Console.Write(".");
            }
            Console.WriteLine("\nFin!");

        }


        static void TpBoucleV3()
        {
            Console.WriteLine("Saisir la chaîne de caractère :");
            string chaine = Console.ReadLine();

            Console.WriteLine("Saisir la hauteur :");
            int hauteur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir la largeur :");
            int largeur = Convert.ToInt32(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    sb.Append(chaine + "\t"); // Affiche la chaîne suivie d'une tabulation

                }
                sb.Append("\n");
            }
            string resultat = sb.ToString();
            Console.WriteLine(resultat);



        }

        static void TestStringBuilder()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("bonjour  ");
            sb.Append("toto  ");
            sb.Append("a bientot  ");

            string res = sb.ToString();
            Console.WriteLine(res);

        }
        static void TestPow()
        {
            double res = System.Math.Pow(2, 3);
            Console.WriteLine(res);
        }
        static void TpBoucleV2()
        {
            string resultat = "";
            Console.WriteLine("Saisir la chaîne de caractère :");
            string chaine = Console.ReadLine();

            Console.WriteLine("Saisir la hauteur :");
            int hauteur = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir la largeur :");
            int largeur = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    resultat += chaine + "\t"; // Affiche la chaîne suivie d'une tabulation
                }
                resultat += "\n"; // Saute une ligne à la fin de chaque ligne de largeur
            }

            Console.WriteLine(resultat);


        }


        static void TestForv6()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) continue;
                Console.WriteLine("coucou " + i);
            }


        }


        static void TestForv5()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5) break;
                Console.WriteLine("coucou " + i);
            }


        }

        static void TestForv4()
        {
            Console.WriteLine("nombre ?");
            int nb = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < nb; i++)
                Console.Write(i + "\t");
            Console.WriteLine("\na bientot");

        }
        static void TestTernairev1()
        {


            Console.WriteLine("saisir le nombre a ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("saisir le nombre b ");
            int b = Convert.ToInt32(Console.ReadLine());

            string resultat;


            resultat = (a == b) ? "a et b egaux" : "a et b differents";

            Console.WriteLine(resultat);

        }
        static void TestSwitchv2()
        {
            Console.WriteLine("saisir: samu? police? domicile-maison");
            string reponse = "NA";
            string saisie = Console.ReadLine();
            //if(saisie=="samu").....

            switch (saisie.ToLower())
            {
                case "samu":
                    reponse = "1234";
                    reponse += "a bientot";
                    break;
                case "police":
                    reponse = "01245";
                    break;

                case "domicile":
                case "maison":
                    reponse = "1212";
                    break;

            }

            Console.WriteLine(reponse);


        }
        static void TestCase()
        {
            string str1 = "toTO";
            string str2 = str1.ToLower();
            string str3 = str1.ToUpper();

            Console.WriteLine(str1);
            Console.WriteLine(str2);
            Console.WriteLine(str3);
        }
        static void TestSwitchv1()
        {
            Console.WriteLine("saisir: samu? police? domicile-maison");
            string reponse = "NA";
            string saisie = Console.ReadLine();
            switch (saisie)
            {
                case "samu":
                    reponse = "1234";
                    break;
                case "police":
                    reponse = "01245";
                    break;

            }

            Console.WriteLine(reponse);


        }
        static void TestTernairev1a()
        {


            Console.WriteLine("saisir le nombre a ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("saisir le nombre b ");
            int b = Convert.ToInt32(Console.ReadLine());

            string resultat;


            resultat = (a == b) ? "a et b egaux" : "a et b differents";

            Console.WriteLine(resultat);

        }
        static void Testifv7()
        {


            Console.WriteLine("saisir le nombre a ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("saisir le nombre b ");
            int b = Convert.ToInt32(Console.ReadLine());

            string resultat;


            if (a == b)
                resultat = "a et b egaux";
            else
                resultat = "a et b differents";

            Console.WriteLine(resultat);



        }

        static void TestIfv6()
        {

            int a = 10;
            int b = 15;
            string resulat = "";
            string str = "";

            if (a == b)
            {
                str = "toto";
                resulat = "a et b egaux";
                Console.WriteLine(str);

            }
            else
            {

            }
            Console.WriteLine(resulat);
            Console.WriteLine(str);

        }
        static void Tpage()
        {
            string status;

            Console.WriteLine("saisir  age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("merci de saisir nom");

            string saisie = Console.ReadLine();
            if ((age > 0) && (age < 18)) //1
                status = "  je suis mineur ";
            else if ((age > 18) && (age < 50)) //2
                status = "  je suis majeur ";
            else if ((age > 50) && (age < 120)) //3
                status = "  je suis senior ";
            else
                status = "erreur";

            Console.WriteLine("Nom{0}  AGE:{1}  STATUS:{2}", saisie, age, status);



        }

        static void TestIfv5()
        {

            Console.WriteLine("saisir un nombre");
            int nombre = Convert.ToInt32(Console.ReadLine());

            if ((nombre > 10) && (nombre < 15)) //2
                Console.WriteLine(" cest entre 10 et 15 ");
            else if (nombre == 11)
                Console.WriteLine("cest 11");
            if (nombre == 12)
                Console.WriteLine("cest 12");

            else
                Console.WriteLine("nombre introuvable ");
            Console.WriteLine("fin de l exemple");

        }
        static void TestIfv4()
        {
            int a = 10;
            int b = 15;

            if (a == b)
            {
                Console.WriteLine("a et b egaux");
            }
            else
            {
                Console.WriteLine("a et b differents");
                Console.WriteLine("a bientot");
            }


        }
        static void TestIfv3()

        {
            int a = 18;
            int b = 15;
            if (a < b)
                Console.WriteLine("a < b ");
            else if (a > b)
                Console.WriteLine("a > b ");

            else
                Console.WriteLine("a = b ");

        }
        static void TestIfv2()
        {
            int a = 10;
            int b = 10;
            if (a == b)
                Console.WriteLine("a et b egaux");
            else
                Console.WriteLine("a et b differents");

        }


        static void M17()
        {
            int a = 7;
            int b;
            b = a++;
            Console.WriteLine("postfix   a:" + a + "     b:" + b);// 8  7
            b = ++a;  //9  9
            Console.WriteLine("prefix a:" + a + "     b:" + b);


        }
        static void M16()
        {
            int a = 10;
            a++;//a+=1;
            a--;
            ++a;
            --a;
            Console.WriteLine(a);

        }
        static void M15()
        {
            int a = 10;
            // rajouter/multiplier par  5
            //a = a + 5;  a=a*5
            a *= 5;


            string str = "bonjour";
            // bonjour toto str=str+"toto";
            str += "toto";

            Console.WriteLine(a);
            Console.WriteLine(str);


        }

        //static void M14()
        //{
        //    int a = 10;
        //    a = 12;


        //    const int b = 15;
        //    b = 16;

        //}
        static void M13()
        {
            Console.Write("hello\n\n");
            Console.Write(12);


        }
        static void M11()
        {
            string nom = "dupond";
            string prenom = "toto";

            // Console.WriteLine("NOM: "+nom+"  PRENOM: "+prenom);
            Console.WriteLine("NOM:{0}  PRENOM:{1}", nom, prenom);
        }
        static void M10()
        {

            string str = "HELLO";  //HELLO TOTO  A-BIENTOT
            str += " TOTO";
            str += " A-BIENTOT";
            Console.WriteLine(str);

        }
        static void M9()
        {
            double x = 10.5;
            //conversion
            string str = "10";
            int a = Convert.ToInt32(str);
            int b = Int32.Parse(str);
            Console.WriteLine(a);
            Console.WriteLine(b);

            string str2 = "10,5";
            double c1 = Convert.ToDouble(str2);
            double c2 = Double.Parse(str2);
            //c += 1;
            c1++;
            c2++;
            Console.WriteLine(c1);
            Console.WriteLine(c2);

        }
        static void M8()
        {
            //conversion
            string str = "10";

            str = str + 1;

            Console.WriteLine(str);

        }
        static void M7()
        {
            //conversion
            string str = "10";
            int a = Convert.ToInt32(str);
            //a = a + 1;
            a += 1;
            Console.WriteLine(a);

        }
        static void M6()
        {
            Console.WriteLine("merci de saisir votre nom");
            string saisie = Console.ReadLine();
            string reponse = "bienvenue " + saisie;
            Console.WriteLine(reponse);

        }
        static void M5()
        {
            string path1 = @"C:\tmp\test.txt";
            string path2 = "C:\\tmp\\test.txt";

            Console.WriteLine(path1);
            Console.WriteLine(path2);

        }

        static void M4()
        {
            string str1 = "bonjour ";
            string str2 = "toto";
            string str3 = str1 + "\t" + str2;
            Console.WriteLine(str3);

        }

        static void M3()
    {

        int a = 1000000;
        string b = "jhgsdhgzhcdghz";
        bool c = false;
        double d = 10.5;

        Console.WriteLine(a);
        Console.WriteLine(b);
        Console.WriteLine(c);
        Console.WriteLine(d);

    }
    static void M2()
        {

            string str1 = "bonjour \t\t toto";
            string str2 = "bonjour \n titi";
            Console.WriteLine(str1);
            Console.WriteLine("------------------------");
            Console.WriteLine(str2);
        }

        static void M1()
            {
                int a;
                string b;
                bool c;
                char d;
                double e;
                Console.WriteLine("je suis M1");
            }

          
        
    }
}
