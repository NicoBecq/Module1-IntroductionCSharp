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
            double AB;
            double BC;
            double CA;
            Console.WriteLine("Soit un triangle ABC rectangle en C.");
            Console.WriteLine("Entrez la valeure du segment BC");
            string SaisieBC = Console.ReadLine();
            BC = double.Parse(SaisieBC);
            Console.WriteLine("Entrez la valeure du segment CA");
            string SaisieCA = Console.ReadLine();
            CA = double.Parse(SaisieCA);
            double ABCarree = (BC * BC) + (CA * CA); // Math.Pow(int Nbre, int Puissance)
            AB = Math.Round(Math.Sqrt(ABCarree), 2); // Arrondi de la racine carré d'ABCarree
            Console.WriteLine("Si BC vaut " + BC + " et CA " + CA + ", alors AB vaut : " + AB );
        }
    }
}
