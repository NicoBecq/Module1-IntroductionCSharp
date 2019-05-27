using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exeercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'un tableau numbers contenant les nombres de 1 à 20
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            // pour tous les nombres de numbers, si le résultat du nombre modulo 2 vaut 0, alors le nombre est pair, donc l'afficher
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Console.WriteLine(number);
                }
            }
        }
    }
}
