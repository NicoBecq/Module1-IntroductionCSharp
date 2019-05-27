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
            int x = 1;
            int y = 2;
            int z = 3;
            Console.WriteLine("X vaut " + x + ", y vaut " + y + ", z vaut" + z);
            int Resultat = (x + y) * z;
            Console.WriteLine(x + " plus " + " y " + "le tout multiplié par " + z + " vaut: " + Resultat);
        }
    }
}
