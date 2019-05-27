using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice7
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'un talbeau numbers contenant les nombres de 1 à 20
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // effectuer un tour de boucle jusqu'a ce que le compteur atteigne 9
            for (int i = 0; i < 10; i ++)
            {
                Console.WriteLine(numbers[i]); // affichage de la valeur correspondant à l'indice 
            }
            // seconde méthode avec un .Take(int nombreElements)
            foreach (int number in numbers.Take(10))
            {
                Console.WriteLine(number); // affichage de la valeur correspondant à l'indice 
            }
        }
    }
}
