using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entez votre nom");
            string Nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prénom");
            string Prenom = Console.ReadLine();
            Console.WriteLine("Entrez votre année de naissance");
            int DateNaissance = int.Parse(Console.ReadLine());
            int AnneeActuelle = DateTime.Now.Year;
            int age = AnneeActuelle - DateNaissance;
            Console.Clear();
            Console.WriteLine("Fiche de renseignement:\n \nNom: " + Nom + "\nPrenom: " + Prenom + "\nDate de naissance: " + age);
        }
    }
}
