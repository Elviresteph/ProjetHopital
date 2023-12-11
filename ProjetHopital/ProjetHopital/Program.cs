using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gestions;
using Dao;

namespace ProjetHopital
{
    class Program
    {

        static void Main(string[] args)
        {
            //TestAuthentification();
            //Authentification user = new Authentification("", "");
            //afficherMenuSecretaire(user);
            //afficherMenuMedecin(user);
            TestAuthentification();
        }

        static void TestAuthentification()
        {
            Console.Write("Entrez votre login : ");
            string login = Console.ReadLine();
            Console.Write("Entrez votre mot de passe : ");
            string password = Console.ReadLine();

            DaoAuthentification d = new DaoAuthentification();
            Authentification utilisateurAuthentifie = d.selectById(login, password);

            if (utilisateurAuthentifie != null)
            {
                switch (utilisateurAuthentifie.metier)
                {

                    case 0:
                        //afficherMenuSecretaire(utilisateur);
                        Console.WriteLine("Menu pour secrétaire");

                        break;

                    case 1:

                        //afficherMenuMedecin(utilisateur);
                        Console.WriteLine("Menu pour m1");
                        break;
                    case 2:
                        Console.WriteLine("Menu pour médecin2");
                        break;
                    default:
                        Console.WriteLine("Métier inconnu");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Échec de l'authentification. Accès refusé.");

            }

        }

       static void afficherMenuSecretaire(Authentification utilisateurAuthentifie)
        {
            int choixSec;
            do
            {
                Console.WriteLine("Menu secrétaire :");
                Console.WriteLine("1. ajouter un patient");      
                Console.WriteLine("2. sauvegarder la liste d’attente");
                Console.WriteLine("3. charger la liste d’attente");
                Console.WriteLine("4. nouvelle journee");
                Console.WriteLine("5. afficher l’etat de la liste d’attente");
                Console.WriteLine("6. afficher les visites d’un patient");
                Console.WriteLine("7. afficher toutes les visites");
                Console.WriteLine("8. afficher toutes les visites d’un medecin");
                Console.WriteLine("9. quitter l’interface secretaire");
                Console.Write("Entrez votre choix : ");

                choixSec = Convert.ToInt32(Console.ReadLine());

                switch (choixSec)
                {
                    case 1:
                        // Logique pour ajouter un patient à la file d'attente


                        //ajouterPatientEnAttente(utilisateurAuthentifie);

                        break;

                    case 2:
                        // Logique pour  Afficher l'état de la liste d'attentee

                        //afficherListeAttente(utilisateurAuthentifie);

                        break;

                    case 3:
                        // Logique pour Afficher le prochain patient de la liste d'attente"
                       // afficherProchainPatient(utilisateurAuthentifie);

                        break;

                    case 4:
                        // Logique pour Afficher les visites d'un patient

                        break;
                    case 5:
                        // Logique pour Quitter l'interface secrétaire et revenir au menu principal
                        Console.WriteLine("Retour au menu principal.");
                        afficherMenuSecretaire(utilisateurAuthentifie);
                        break;

                    default:
                        Console.WriteLine("Option invalide. Veuillez choisir à nouveau.");
                        break;
                }

            } while (choixSec != 5);

        }

        static void afficherMenuMedecin(Authentification utilisateurAuthentifie)
        {
            int choixSec;
            do
            {
                Console.WriteLine("Menu medecin :");

                Console.WriteLine("1. afficher l’etat de la file d’attente");
                Console.WriteLine("2. ajouter une ordonnance du patient present");
                Console.WriteLine("3. sauvegarder la base de donnée de la liste des visites");
                Console.WriteLine("4. rendre la salle disponible");
                Console.WriteLine("5. Quitter l'interface medecin et revenir au menu principal");

                Console.Write("Entrez votre choix : ");
                choixSec = Convert.ToInt32(Console.ReadLine());
                switch (choixSec)
                {
                    case 1:
                        // Logique pour Rendre la salle dispo



                        break;

                    case 2:
                        // Logique pour  fficher la file d attente
                        //afficherListeAttente(utilisateurAuthentifie);


                        break;

                    case 3:
                        // Logique pour afficher la liste des visites"
                        //afficherListeVisites(utilisateurAuthentifie);

                        break;
                    case 4:
                        // Logique pour Quitter l'interface medecin et revenir au menu principal"
                        Console.WriteLine("Retour au menu principal.");
                        afficherMenuMedecin(utilisateurAuthentifie);

                        break;



                    default:
                        Console.WriteLine("Option invalide. Veuillez choisir à nouveau.");
                        break;
                }


            } while (choixSec != 4);




        }
    }
}
