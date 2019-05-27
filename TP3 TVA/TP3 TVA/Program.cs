using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_TVA
{
    class Program
    {
        static void Main(string[] args)
        {
            bool progExe = true;
            // boucle programme pour pouvoir relancer les calculs ou quitter le programme
            while (progExe)
            {
                Console.WriteLine("Pour lancer le programme de calcul de la TVA, appuyez sur \"p\", pour quitter le programe, apuuyez sur\"e\"");
                string wantToCalc = Console.ReadLine(); // stockage de l'entrée utilisateur, sinon on ne peux pas sortir de la boucle en entrant "e"
                if (wantToCalc.ToLower() == "p")
                {
                    Console.WriteLine("Bienvenue dans le calculateur de TVA\nEntrez le prix de l'article");
                    string userInput = Console.ReadLine();
                    // si l'entrée est convertible en double, et est une valeure possible, calculer son prix HT et afficher le message
                    if (double.TryParse(userInput, out double priceHT) && priceHT > 0)
                    {
                        double priceTTC = priceHT * 1.20;
                        Console.WriteLine($"L'article coûte {priceHT} euros, et donc {priceTTC} euros taxes comprises");
                    }
                    // sinon erreur de saisie
                    else
                    {
                        Console.WriteLine("Saisie incorrecte, veuillez rentrer un nombre");
                    }
                }
                else if (wantToCalc.ToLower() == "e")
                {
                    progExe = false; // progExe devient faux donc on sort de la boucle progExe
                }
                else
                {
                    Console.WriteLine("Saisie non reconnue, veuillez réessayer");
                }
            }
        }
    }
}
