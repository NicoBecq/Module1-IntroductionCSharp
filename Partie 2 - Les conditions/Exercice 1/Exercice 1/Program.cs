using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool rainy; // initialisation de la variable
            rainy = false; // attribution d'une valeur à cette variable

            // Si il pleut, prévenir l'utilisateur de prendre son parapluie, sinon lui dire que c'est bon.
            if (rainy)
            {
                Console.WriteLine("Bonjour, il pleut aujourd'hui, vous devriez prendre votre parapluie");
            }
            else
            {
                Console.WriteLine("Bonjour, il ne pleut pas aujourd'hui, bonne journée");
            }
        }
    }
}
