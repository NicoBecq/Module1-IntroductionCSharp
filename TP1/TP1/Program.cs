using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrez votre poids:");
            string weightInput = Console.ReadLine(); // stockage du poids utilisateur
            // si on peut le convertir en double, essayer de convertir sa taille, sinon afficher message d'erreur
            if (double.TryParse(weightInput, out double weight) && weight > 10 && weight < 170)
            {
                Console.WriteLine("Entrez votre taille:"); 
                string sizeInput = Console.ReadLine(); // lecture et stockage de la taille utilisateur
                // si on peut convertir en double, calculer IMC, sinon afficher message d'erreur
                if (double.TryParse(sizeInput, out double size) && size > 0 && size < 2.5)
                {
                    // calcul de l'IMC ( poids / taille² )
                    double IMC = weight / Math.Pow(size, 2);
                    // Si l'imc est inférieur à 16,5 afficher le message correspondant
                    if (IMC < 16.5)
                    {
                        Console.WriteLine($"Votre IMC est de: {IMC} il correspond à une dénutrition.");
                    }
                    // sinon, si IMC est compris entre 16,5 et 18,5 afficher le message correspondant ...
                    else if (IMC > 16.5 && IMC < 18.5)
                    {
                        Console.WriteLine($"Votre IMC est de: {Math.Round(IMC, 2)} il correspond à maigreur.");
                    }
                    else if (IMC > 18.5 && IMC < 25)
                    {
                        Console.WriteLine($"Votre IMC est de: {Math.Round(IMC, 2)} il correspond à une corpulence normale.");
                    }
                    else if (IMC > 25 && IMC < 30)
                    {
                        Console.WriteLine($"Votre IMC est de: {Math.Round(IMC, 2)} il correspond à un surpoids.");
                    }
                    else if (IMC > 30 && IMC < 35)
                    {
                        Console.WriteLine($"Votre IMC est de: {Math.Round(IMC, 2)} il correspond à une obésité modérée.");
                    }
                    else if (IMC > 35 && IMC < 40)
                    {
                        Console.WriteLine($"Votre IMC est de: {Math.Round(IMC, 2)} il correspond à une obésité sévère.");
                    }
                    else if (IMC > 40)
                    {
                        Console.WriteLine($"Votre IMC est de: {Math.Round(IMC, 2)} il correspond à une obésité morbide ou massive.");
                    }
                }
                else
                {
                    Console.WriteLine("Saisie non reconnue, veuillez réessayer");
                }
            }
            else
            {
                Console.WriteLine("Saisie non reconnue, veuillez réessayer");
            }
        }
    }
}
