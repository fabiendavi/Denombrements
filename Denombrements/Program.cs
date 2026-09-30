using System;

namespace Denombrements
{
    class Program
    {
        static long Multiplication(int valeurDepart, int valeurArrivee)
        {
            long resultat = 1;
            for (int k = valeurDepart; k <= valeurArrivee; k++)
            {
                resultat *= k;
            }
            return resultat;
        } 
        static void Main(string[] args)
        {
            string choix = "1";
            while (choix != "0")
            {
                Console.WriteLine("Permutation ...................... 1");
                Console.WriteLine("Arrangement ...................... 2");
                Console.WriteLine("Combinaison ...................... 3");
                Console.WriteLine("Quitter .......................... 0");
                Console.Write("Choix :                            ");
                choix = Console.ReadLine();

                int nbTotal=0, sousEnsemble=0;
                long resultat1=1, resultat2=1, resultat3=1;

                if (choix == "0")
                {
                    Environment.Exit(0);
                }

                if (choix == "1" || choix == "2" || choix == "3")
                {
                    bool saisieValide = false; // on crée une variable booléenne pour vérifier que n soit bien entier
                    while (!saisieValide)
                    {
                        try
                        {
                            Console.Write("nombre total d'éléments à gérer = ");
                            nbTotal = int.Parse(Console.ReadLine());
                            saisieValide = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie : veuillez entrer un nombre entier !");
                        }
                    }
                    
                }
                else
                {
                    Console.WriteLine("Erreur de saisie");
                }
                if (choix == "2"|| choix == "3")
                {
                    bool saisieValide2 = false;
                    while (!saisieValide2)
                    {
                        try
                        {
                            Console.Write("nombre d'éléments dans le sous ensemble = ");
                            sousEnsemble = int.Parse(Console.ReadLine());
                            saisieValide2 = true;
                        }
                        catch
                        {
                            Console.WriteLine("Erreur de saisie : veuillez entrer un nombre entier !");
                        }
                    }
                    
                }
                
                switch (choix)
                {
                    case "1":

                        // calcul de resultat1
                        resultat1 = Multiplication(1, nbTotal);
                        Console.WriteLine(nbTotal + "! = " + resultat1);
                        break;

                    case "2":

                        // calcul de resultat2
                        resultat2 = Multiplication(nbTotal - sousEnsemble + 1, nbTotal);
                        Console.WriteLine("A(" + sousEnsemble + "/" + nbTotal + ") = " + resultat2);
                        break;

                    case "3":

                        // calcul de resultat2
                        resultat2 = Multiplication(nbTotal - sousEnsemble + 1, nbTotal);

                        // calcul de resultat3
                        resultat3 = Multiplication(1, sousEnsemble);

                        Console.WriteLine("C(" + sousEnsemble + "/" + nbTotal + ") = " + (resultat2 / resultat3));
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
