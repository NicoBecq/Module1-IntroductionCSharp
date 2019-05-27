using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bonjour et bienvenu!"); // message de bienvenue
            bool wantToPlay = true; //initialisation d'un bool pour pouvoir sortir du programme
            // boucle permettant de demander au joueur si il souhaite jouer ou quitter le proggrame
            while(wantToPlay)
            {
                Console.WriteLine("Pour lancer le jeu appuyez sur \"p\", si vous voulez quitter le programme, appyez sur \"e\".");
                string playOrNot = Console.ReadLine().ToLower(); //stockage du choix de l'utilisateur (jouer ou quitter)
                // si le joueur saisi "p", jouer, sinon si il saisi "e" sortir de la boucle. while(wantToPlay)
                if (playOrNot == "p")
                {
                    Random Rnd = new Random(); // initialisation d'une instance de l'objet Random
                    int GeneratedNumber = Rnd.Next(1, 51); // génération d'un nbre aléatoire
                    Console.WriteLine("Bienvenue au juste prix, veuillez rentrer un nombre compris entre 1 et 50");
                    bool found = false; //initialisation d'une variable bool pour sortir de la boucle
                    int i = 1; // initialisation d'un compteur pour le nombre d'essais
                    while (!found)
                    {
                        string userInput = Console.ReadLine(); // lecture et stockage de la saisie utilisateur
                        // si on peut convertir la saisie de l'utilisateur en int, comparer avec le Rnd, sinon message d'erreur
                        if (int.TryParse(userInput, out int userNumber) && userNumber > 0 && userNumber <=50)
                        {
                            // si l'entrée utilisateur est inférieure à GeneratedNumber, afficher message
                            if (userNumber < GeneratedNumber)
                            {
                                Console.WriteLine("C'est plus grand...");
                                i++; // c'est raté du coup incrémentation du compteur d'essais
                            }
                            // sinon, si l'entrée utilisateur est supérieure afficher message
                            else if (userNumber > GeneratedNumber)
                            {
                                Console.WriteLine("C'est plus petit...");
                                i++; // c'est raté du coup incrémentation du compteur d'essais
                            }
                            // sinon, si c'est le bon nombre, afficher le message de réussite
                            else if (userNumber == GeneratedNumber)
                            {
                                Console.WriteLine($"Bravo, le nombre à deviner était {GeneratedNumber}, vous l'avez trouvé en {i} essais!");
                                found = true; // changement de valeur de la variable pour pouvoir sortir de la boucle
                                break;
                            }
                            // Sinon la saisie n'est pas reconnue donc message d'erreur
                        }
                        else
                        {
                            Console.WriteLine("La saisie n'est pas reconnue, veuillez réessayer");
                        }
                    }
                }
                else if (playOrNot == "e")
                {
                    wantToPlay = false;
                    break;
                }
                else
                {
                    Console.WriteLine("La saisie n'est pas reconnue.");
                }
            }
        }
    }
}
