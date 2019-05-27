using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre age"); 
            string ageInput = Console.ReadLine();
            // si on peut convertir l'age, sinon fin du programme avec message d'erreur
            if (int.TryParse(ageInput, out int age))
            {
                // vérifier si l'age est possible
                if(age < 1 || age > 110)
                {
                    Console.WriteLine("Entrez homme si vous êtes un homme, femme si vous êtes une femme");
                    string gender = Console.ReadLine().ToLower(); // lecture et stockage de la saisie utilisateur sur son genre

                    // Si c'est un homme, vérifier si il est majeur.
                    if (gender == "homme")
                    {
                        // si il a moins de 18 ans il est mineur, sinon il est majeur
                        if (age < 18)
                        {
                            Console.WriteLine("Vous êtes un homme, et vous êtes mineur");
                        }
                        else
                        {
                            Console.WriteLine("Vous êtes un homme, et vous êtes majeur");
                        }
                    }
                    // sinon si c'est une femme, vérifier si elle est majeur
                    else if (gender == "femme")
                    {
                        // si elle a moins de 18 ans elle est mineur, sinon elle est majeur
                        if (age < 18)
                        {
                            Console.WriteLine("Vous êtes une femme, et vous êtes mineur");
                        }
                        else
                        {
                            Console.WriteLine("Vous êtes une femme, et vous êtes majeur");
                        }
                    }
                    // sinon la saisie n'est pas reconnue
                    else
                    {
                        Console.WriteLine("La saisie n'est pas reconnue");
                    }
                }
            }
            else
            {
                Console.WriteLine("La saisie n'est pas reconnue");
            }
        }
    }
}
