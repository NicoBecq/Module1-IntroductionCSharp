using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre age:"); // Demande de saisir l'age utilisateur
            string UserInput = Console.ReadLine(); //Lecture et conversion, puis stockage de la saisie utilisateur
            // utiliser un tryParse
            if (int.TryParse(UserInput, out int age)) // si la saisie est convertible, vérifier l'age
            {
                // vérif si l'age est dans les limites du possible avant de vérifier si il est majeur
                // Si il à moins de 18 ans il est mineur, sinon il est majeur
                if (age < 18)
                {
                    Console.WriteLine("Vous avez " + age + " ans, vous êtes donc mineur.");
                }
                else if (age > 18)
                {
                    Console.WriteLine("Vous avez " + age + " ans, vous êtes donc majeur.");
                }
                else
                {
                    Console.WriteLine("La saisie n'est pas reconnue");
                }
            }
            else
            {
                Console.WriteLine("La saisie n'est pas reconnue");
            }
        }
    }
}
