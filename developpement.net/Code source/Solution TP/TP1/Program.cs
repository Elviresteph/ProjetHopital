using System;
using System.Text;


namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tpInfos();
            //tpCalculArticle();
            //tpMax();
            //tpAge();
            //tpTernaire();
            //tpMenu();
            //tpBouclev1();
            //TpPuissancev2();
            //UserCalculArticle1();
            //TestTableauIntv2();
            tpTraitementTexte();

        }

        static void tpTraitementTexte()
        {
            Console.Write("Saisissez une phrase : ");
            string phrase = Console.ReadLine();
            string  reponse = traitementText(phrase);
            Console.Write("reponse: " + reponse.ToUpper());
            Console.WriteLine();

        }

        static string traitementText(string str)
        {
            string[] mots = str.Split(' ');
            string[] tabStringReverse = Reverse(mots);
            string reponse = "";

            foreach (string e in tabStringReverse)
            {
                reponse = reponse + " " + e;
            }
            return reponse;
        }
        

        static void tpReverse()
        {
            int[] tabInt = {1,2,3,4,5};
            string[] tabString = { "aa", "bb", "cc", "dd" };
            int[] tabIntReverse = Reverse(tabInt);
            string[] tabStringReverse = Reverse(tabString);

            Affiche(tabInt);
            Affiche(tabIntReverse);
            Affiche(tabString);
            Affiche(tabStringReverse);
        }

        static int[] Reverse(int[] x)
        {
            int[] y = new int[x.Length];

            for (int i = 0; i < y.Length; i++)
                y[i] = x[(y.Length - 1) - i];
            return y;

        }

        static string[] Reverse(string[] x)
        {
            string[] y = new string[x.Length];

            for (int i = 0; i < y.Length; i++)
                y[i] = x[(y.Length - 1) - i];
            return y;

        }
        static void Affiche(int[] x)
        {

            foreach (int e in x)
                Console.Write(e + "\t");
            Console.WriteLine();
        }
        static void Affiche(string[] x)
        {

            foreach (string e in x)
                Console.Write(e + "\t");
            Console.WriteLine();
        }


        static void tpOccurrence()
        {
            int[] tab = { 10, 2, 30, 10, 1, 2, 5, 10 };         
            Console.WriteLine("Saisir un nombre entier: ");
            int nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nombre de fois: " + occurrence(tab, nombre));
        }
        static void Affiche1(int[] x)
        {
            foreach (int e in x)
                Console.Write(e + "\t");
            Console.WriteLine();
        }

        static int occurrence(int[] tab, int nombre)
        {
            int compteur = 0;

            for (int i = 0; i < tab.Length; i++)
            {
                if(tab[i] == nombre)
                {
                    compteur++;
                }
            }
            return compteur;
        }


        static void TestTableauIntv2()
        {
            int[] tab = { 10, 20, 30, 40, 50 };
            for (int i = 0; i < tab.Length; i++)
                Console.Write(tab[i] + "\t");
        }

       /* static void Affiche(int[] x)
        {

            foreach (int e in x)
                Console.Write(e + "\t");
            Console.WriteLine();
        }*/

        static void TpTableauv1()
        {
            Console.WriteLine("Saisir la taille du tableau: ");
            int size = Convert.ToInt32(Console.ReadLine());

            string[] tab = new string[size];

            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Saisir l'element n°" + (i + 1) + " du tableau: (chaine de caracteres)");
                tab[i] = Console.ReadLine();
            }
            StringBuilder tableauAff = new StringBuilder();
            tableauAff.AppendLine("Elements du tableau: ");
            tableauAff.Append(tab[0]);
            for (int i = 1; i < size; i++)
            {
                tableauAff.Append("\t" + tab[i]);
            }
            tableauAff.Append("\n");
            Console.Write(tableauAff);
        }
        //static void TpTableauv1()
        //{
        //    Console.WriteLine("Veuillez saisir la taille du tableau : ");
        //    int taille = Convert.ToInt32(Console.ReadLine());
        //    string[] tableau = new string[taille];
        //    for(int i=0; i<taille; i++)
        //    {
        //        Console.WriteLine("veuillez saisir l'element (i+1): chaine de caractere");
        //        tableau[i] = Console.ReadLine();
        //    }
        //    Console.WriteLine("Recapitulatif du tableau:");
        //    for (int i = 0; i < taille; i++)
        //        Console.WriteLine("veuillez saisir l'element (i+1); tableau[i]:");
        //}



        static void TpSimulateurCredit()
        {

            Console.WriteLine("Veuillez saisir votre nom : ");
            string client = Console.ReadLine();

            Console.WriteLine("Veuillez entrer votre age : ");
            double age = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veuillez entrer votre salaire (brut) :");
            double salaireBrut = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Veuillez entrer le montant de l'emprunt :");
            double emprunt = Convert.ToDouble(Console.ReadLine());

            string reponse = CalculCredit(salaireBrut, age, emprunt);
            Console.WriteLine("| Client: {0}, Age: {1} ans \n{2}", client, age, reponse);

        }
        static string CalculCredit(double salaireBrut, double age, double montant)
        {
            double salaireNetAnnuel = (salaireBrut - Pourcentage(salaireBrut, 23)) * 12;
            double taux = GetTaux(age);
            string resultat = TestCredit(salaireNetAnnuel, taux, montant);
            return resultat;
        }

        static string TestCredit(double salaireNetAnnuel, double taux, double montant)
        {
            double creditMax = salaireNetAnnuel * Pourcentage(1, taux);
            double tauxRemboursement = Pourcentage(montant, 3);
            string resultat = "| Salaire Annnuel Brut: " + salaireNetAnnuel + " euros \n";
            if (taux == 0)
                resultat += "| Vous devez être entre 18 et 70 ans pour bénéficier d'un crédit.";
            else if (montant < creditMax)
                resultat += "| Credit OK. remboursement total de " + montant + " euros + " + tauxRemboursement + " euros (3%) lissé sur 12 mois.";
            else
                resultat += "| Désolé, vous ne pouvez pas bénéficier d'un crédit de " + montant + " euros.";
            return resultat;
        }

        static double GetTaux(double age)
        {
            double taux = 0;
            if ((age >= 18) && (age <= 30))
                taux = 15;
            else if ((age > 30) && (age <= 50))
                taux = 20;
            else if ((age > 50) && (age <= 70))
                taux = 10;
            return taux;
        }

        static double Pourcentage(double nb, double pourcentage)
        {
            double resultat = nb * (pourcentage / 100);
            return resultat;
        }
        static void userSimulateurCredit()
        {
            Console.WriteLine("saisir nom");
            string nom = Console.ReadLine();
            Console.WriteLine("merci de saisir votre age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("saisir votre salaire brut mensuel");
            double sbrutmen= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("saisir le montant emprunt");
            double memp = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(devSimulateurCredit(age, sbrutmen, memp));
        
        }

        static string devSimulateurCredit(int age, double sbrutmen, double memp)
        {
            // salaire net = salaire brut - 23 % du salaire brut
            double salaireNet = sbrutmen - (23 * sbrutmen/100);
            //taux
            int taux = calculTaux(age);
            if(taux != 0)
            {
                if (memp < taux * salaireNet) {

                    double remboursementTotal = memp  +  3 * memp / 100;

                    return "ok le remboursement se fera sur 1 an avec une taxe de 3 %, remboursement total: " + remboursementTotal;
                }
                else
                {
                    return "erreur";
                }
            }
            else
            {
                return "erreur";
            }
            /*il faut que montant emprunté < taux * salaire_annuel_net
             * si cest ok le remboursement se fera sur 1 an avec une taxe de 3 %, qui sera affiché a la utilisateur
            l emprunt ne peut se faire que entre 18 et 70 sinon erreur,*/

        }

        static int calculTaux(int age)
        {
            //regle: 18 - 30 - 15  31 - 50 - 20  51 - 70 - 10
            int taux;

            if (age >= 18 && age <= 30)
            {
                taux = 15; 
            }
            else if(age>=31 && age<=50)
            {
                taux = 20;
            }
            else if (age >= 51 && age <= 70)
            {
                taux = 10;
            }
            else
            {
                taux = 0;
            }
            return taux;
        }



        static void tpCalcul()
        {
            Console.WriteLine("saisir le nb1");
            double nb1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("saisir le nb2");
            double nb2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("1. addition:");
            Console.WriteLine("2. soustraction:");
            Console.WriteLine("3. multiplication:");
            Console.WriteLine("4. division:");
            Console.WriteLine("choisissez une operation(1-4):");
            int choix = Convert.ToInt32(Console.ReadLine());

            string resultat = Operation(nb1, nb2, choix);

            Console.WriteLine(resultat);

        }

        static string Operation(double nb1, double nb2, int ope) { 

            switch (ope)
            {
                case 1:          
                    return Convert.ToString(Add(nb1, nb2));
                case 2:
                    return Convert.ToString(sous(nb1, nb2));
                case 3:
                    return Convert.ToString(Multi(nb1, nb2));
                case 4:
                    if (nb2 != 0)
                    {
                        return Convert.ToString(Div(nb1, nb2));
                    }
                    else
                    {
                        return "err";
                    }
                default:
                    return "err2";
            }           
        }

        static double Add(double a, double b)
        {
            return a + b;
        }
        static double sous(double a, double b)
        {
            return a - b;
        }
        static double Multi(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }


        static void UserCalculArticle1()
        {
            Console.WriteLine("saisir marque");//zara
            string marque = Console.ReadLine();

            Console.WriteLine("saisir prix  ht avant promo");//10
            double prixHt = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("saisir  tva");//20
            double tva = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("saisir  la reduction");
            double reduction = Convert.ToDouble(Console.ReadLine());//25

            double prixfinal = devCalculArticle1(prixHt, tva, reduction);
            Console.WriteLine("prix final marque est: " + prixfinal);
        }

        static double devCalculArticle1(double prixHt, double tva, double reduction)
        {
            double prixttc = prixHt * (1 + (tva / 100));
            double prixfinal = prixttc * (1 - reduction / 100);
            return prixfinal;
        }



        static void TpPuissancev2()
        {
            Console.WriteLine("Merci d'indiquer un nombre:");
            int nb = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Merci d'indiquer sa puissance:");
            int puissance = Convert.ToInt32(Console.ReadLine());
            Puissancev2(nb, puissance);
        }

        static void Puissancev2(int nombre, int puissance)
        {
          
            int resultat = 1;
            for (int i = 0; i < puissance; i++)
            {
                resultat = resultat * nombre;
            }

            Console.WriteLine(resultat);

        }


        static void TpRandomV22()
        {
            Random r = new Random();
            int nbAleatoire = r.Next(0, 11);
            Console.WriteLine(nbAleatoire);
            int nbrtentative = 0;
            bool boucle = true;
            Console.WriteLine("Devinez le nb entre 0 et 10:");
            int nbrMax = 5;
            while (boucle)
            {
                int tentativeUtilisateur = Convert.ToInt32(Console.ReadLine());
                nbrtentative++;
                if (tentativeUtilisateur == nbAleatoire)
                {
                    Console.WriteLine("Bravo vous avez devine le nombre en " + nbrtentative + " tentative !:");
                    boucle = false;
                }
                else
                {
                    if(nbrtentative >= nbrMax)
                    {                 
                        Console.WriteLine("game over");
                        boucle = false;
                    }
                    else
                    {
                        if (tentativeUtilisateur < nbAleatoire)
                        {
                            Console.WriteLine("cest -  essai incorrect. Essayez encore:");
                        }
                        else
                        {
                            Console.WriteLine("cest +  essai incorrect. Essayez encore:");
                        }
                    }                 
                }
            }
        }

        static void TpRandomV21()
        {
            Random r = new Random();
            int nbAleatoire = r.Next(0, 11);
            Console.WriteLine(nbAleatoire);
            int nbrtentative = 0;
            bool boucle = true;
            Console.WriteLine("Devinez le nb entre 0 et 10:");
     
            while (boucle)
            {
                int tentativeUtilisateur = Convert.ToInt32(Console.ReadLine());
                nbrtentative++;
                if (tentativeUtilisateur == nbAleatoire)
                {
                    Console.WriteLine("Bravo vous avez devine le nombre en "+ nbrtentative + " tentative !:");
                     boucle = false;
                }
                else
                {
                    if(tentativeUtilisateur < nbAleatoire)
                    {
                        Console.WriteLine("cest -  essai incorrect. Essayez encore:");
                    }
                    else
                    {
                        Console.WriteLine("cest +  essai incorrect. Essayez encore:");
                    }           
                }
            }
        }

        static void TpRandom()
        {
            Random r = new Random();
            int nbAleatoire = r.Next(0, 11);
            Console.WriteLine(nbAleatoire);
            int tentative = 0;
            bool boucle = true;
            Console.WriteLine("Devinez le nb entre 0 et 10:");

            while (boucle)
            {
                int tentativeUtilisateur = Convert.ToInt32(Console.ReadLine());
                tentative++;
                if (tentativeUtilisateur == nbAleatoire)
                {
                    Console.WriteLine("Bravo vous avez devine le nombre en " + tentative + " tentative !:");
                    boucle = false;
                }
                else
                {
                    if (tentativeUtilisateur < nbAleatoire)
                    {
                        Console.WriteLine("cest -  essai incorrect. Essayez encore:");
                    }
                    else
                    {
                        Console.WriteLine("cest +  essai incorrect. Essayez encore:");
                    }
                }
            }
        }

        static void TpPuissance()
        {
            Console.WriteLine("Saisir un nombre :");
            int nombre = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Saisir sa puissance :");
            int puissance = Convert.ToInt32(Console.ReadLine());
            int resultat = 1;
            for (int i = 0; i < puissance; i++)
            {
                resultat = resultat * nombre;
            }
            Console.WriteLine(resultat);
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
            Console.ReadKey();
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

        static void tpBouclev1()
        {
            Console.WriteLine("merci de saisir une chaine caractere ");
            string caractere = Console.ReadLine();
            Console.WriteLine("merci de saisir une hauteur");
            int hauteur = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("merci de saisir une largeur");
            int largeur = Convert.ToInt32(Console.ReadLine());

            string t ="";

            for(int i = 0; i < hauteur; i++)
            {
                for (int j = 0; j < largeur; j++)
                {
                    t  = t + caractere + "\t"; 
                    
                }
                Console.WriteLine(t);
                t = "";
            }
        }

        static void tpInfos()
        {
            Console.WriteLine("merci de saisir votre nom");
            string nom = Console.ReadLine();
            Console.WriteLine("merci de saisir votre prenom");
            string prenom = Console.ReadLine();
            Console.WriteLine("merci de saisir votre annéé de naissance");
            int anneeNaissance = Convert.ToInt32(Console.ReadLine());
            int age = 2023 - anneeNaissance;
            Console.WriteLine("merci de saisir votre taille");
            double taille = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("merci de saisir votre poids");
            int poids = Convert.ToInt32(Console.ReadLine());
            string reponse = "nom: "+  nom + "\t" + "prenom: " + prenom + "\n" + "age: "+ age + "\n" + "taille: " + taille + " poids: "  + poids;
            Console.WriteLine(reponse);
            Console.ReadKey();
            //Console.WriteLine(age);
            //string reponse2 = "taille: " + taille + "poids: " + poids;
            //Console.WriteLine(reponse2);
        }

        static void tpCalculArticle()
        {
            Console.WriteLine("merci de saisir la marque de l'article");
            string marque = Console.ReadLine();
            Console.WriteLine("merci de saisir le prix ht");
            double prixHt = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("merci de saisir la tva a appliquer(entier en %)");
            int tva = Convert.ToInt32(Console.ReadLine());
            double prixTTC = prixHt + (prixHt * tva/100);
            double prixTTCRemise = prixTTC - (prixTTC * 25 / 100);
            string reponse = "marque: " + marque + "\n" + "prix ht: " + prixHt + "\n" + "prix ttc: " + prixTTC + "\n" + "prix ttc apres reduction: " + prixTTCRemise;
            Console.WriteLine(reponse);
            Console.ReadKey();

        }
        static void tpMax()
        {
            Console.WriteLine("merci de saisir la valeur de a:");
            int a = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("merci de saisir la valeur de b:");
            int b = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("merci de saisir la valeurs de b:");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            if(b>max)
            {
                max = b;
            }
            if(c>max)
            {
                max = c;
            }
            Console.WriteLine("le maximum entre a b et c est:" +max);
        }

        /* 
            demander a l utilisateur de saisir au clavier son nom et age
            en fonction de la tranche d age , on fixe son status: erreur ou mineur ou majeur ou senior

            entre 0 exclu et 18 exclu , je suis mineur

            entre 18 inclu et 50 exclu je suis majeur

            entre 50 et 120 senior

            pour les negatifs zero inclu  et les superieurs a 120; status erreu
       */

        static void tpAge()
        {
            Console.WriteLine("merci de saisir votre nom:");
            string nom = Console.ReadLine();
            Console.WriteLine("merci de saisir votre age:");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age>0 && age<18)
            {
                Console.WriteLine("je suis mineur");
            }
            else if(age>=18 && age<50)
            {
                Console.WriteLine("je suis majeur");
            }
            else if(age>=50 && age<=120)
            {
                Console.WriteLine("je suis senior");
            }
            else
            {
                Console.WriteLine("je suis status erreur");
            }
        }



        static void tpTernaire()
        {
            Console.WriteLine("merci de saisir le chiffre a:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("merci de saisir le chiffre b:");
            int b = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("merci de saisir le chifre c:");
            int c = Convert.ToInt32(Console.ReadLine());
            int max = a;
            string resultat;
            resultat = a > b ? (a > c ? "a le plus grand avec " + a : "c le plus grand avec " + c) : b > c ? "b le plus grand avec " + b : "c le plus grand avec " + c;
            Console.WriteLine(resultat);
        }
        static void tpMenu()
        {
            Console.WriteLine("choisir 1.tpInfos 2.tpCalculArticle 3.tpMax 4.tpAge 5.tpTernaire");
            int saisie = Convert.ToInt32(Console.ReadLine());
            switch (saisie)
            {
                case 1:
                    tpInfos();
                    break;
                case 2:
                    tpCalculArticle();
                    break;
                case 3:
                    tpMax();
                    break;
                case 4:
                    tpAge();
                    break;
                case 5:
                    tpTernaire();
                    break;
            }

        }
    }
}
