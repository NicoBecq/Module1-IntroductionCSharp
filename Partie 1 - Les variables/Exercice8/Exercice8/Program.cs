using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez le rayon de votre cercle");
            string SaisieRayon = Console.ReadLine();
            double Rayon = Convert.ToInt32(SaisieRayon);
            double Surface = 3.14 * (Rayon * Rayon); //Math.PI (pour pi)
            double Perimetre = 2 * 3.14 * Rayon;
            Console.WriteLine("La surface d'un cercle de rayon " + Rayon + " est " + Surface + " cm².");
            Console.WriteLine("Le périmèrte d'un cercle de rayon " + Rayon + " est " + Perimetre + " cm."); // On arrondi parcequ'on utilise la vrai valeure de pi.
        }
    }
}
