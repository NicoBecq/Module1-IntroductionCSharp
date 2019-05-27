using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice4
{
    class Program
    {
        static void Main(string[] args)
        {
            // création d'une liste shopping
            List<string> shopping = new List<string>();
            // multiples ajouts a la liste
            shopping.Add("Carottes");
            shopping.Add("Oignons");
            shopping.Add("Pommes de terre");
            shopping.Add("Salade");
            shopping.Add("Tomate");
            Console.WriteLine(shopping[2]); // affichage de la valeur correspondante à l'indice 2 de la liste shopping
        }
    }
}
