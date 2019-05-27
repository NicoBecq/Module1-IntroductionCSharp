using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a; // double ou float pour précision après la virgule (parceque division)
            int b;
            Console.WriteLine("Entrez un premier nombre entier");
            string SaisieA = Console.ReadLine();
            Console.WriteLine("Entrez un second nombre entier");
            string SaisieB = Console.ReadLine();
            a = Convert.ToInt32(SaisieA); //a = int.Parse(Console.ReadLine());
            b = Convert.ToInt32(SaisieB);
            a += 33;
            b++;
            int result = a / b;
            Console.WriteLine("La division de " + a + " plus 33, et de " + b + " plus 1 vaut " + result);
        }
    }
}
