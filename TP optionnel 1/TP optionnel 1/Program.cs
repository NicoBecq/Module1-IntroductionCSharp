using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_optionnel_1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool programExe = true;
            Console.WriteLine("Bienvenue dans le programme pour calcluer votre moyenne!");
            // boucle pour pouvoir lancer, ou relancer le calcul
            while (programExe)
            {
                Console.WriteLine("Pour calculer votre moyenne, appuyer sur \"p\" pour lancer le programme, ou sur \"e\" pour le quitter.");
                string launchInput = Console.ReadLine().ToLower();
                // si l'utilisateur saisi "p", calculer, sinon si il rentre "e", sortir de la boucle et quitter, sinon afficher message d'erreur
                if (launchInput == "p")
                {
                    // création d'une liste contenant les notes de l'élève
                    List<float> notes = new List<float>();
                    bool inputEnd = false;
                    Console.WriteLine("Entrez votre prénom");
                    string userName = Console.ReadLine();
                    Console.WriteLine("Entrez vos notes en appuyant sur entrée entre chaque, puis \"f\" lorsque vous avez fini");
                    while(!inputEnd)
                    {
                        string noteInput = Console.ReadLine();
                        // si c'est possible de convertir la saisie, ajouter cette dernière à la liste
                        if (float.TryParse(noteInput, out float note) && note >= 0 && note <= 20)
                        {
                            notes.Add(note);
                        }
                        // sinon si c'est f, sortir de la boucle
                        else if (noteInput.ToLower() == "f")
                        {
                            inputEnd = true;
                            break;
                        }
                        // sinon la saisie est incorrecte
                        else
                        {
                            Console.WriteLine("La saisie est incorrecte");
                        }
                    }
                    // calculer la moyenne
                    if (notes.Count > 0)
                    {
                        // calcul de la moyenne
                        float noteSum = 0;
                        for (int i = 0; i < notes.Count; i++)
                        {
                            noteSum += notes[i];
                        }
                        float averageNote = noteSum / notes.Count;
                        string comment = "";
                        // comparer averageNote avec le tableau des apréciations
                        if (averageNote < 6)
                        {
                            comment = "Très insuffisant";
                        }
                        else if (averageNote >= 6 && averageNote < 10)
                        {
                            comment = "Insuffisant";
                        }
                        else if (averageNote >= 10 && averageNote < 12)
                        {
                            comment = "Passable";
                        }
                        else if (averageNote >= 12 && averageNote < 14)
                        {
                            comment = "Assez bien";
                        }
                        else if (averageNote >= 14 && averageNote < 16)
                        {
                            comment = "Bien";
                        }
                        else if (averageNote >= 16 && averageNote < 18)
                        {
                            comment = "Très bien";
                        }
                        else if (averageNote >= 18 && averageNote < 20)
                        {
                            comment = "Excellent";
                        }
                        else if (averageNote == 20)
                        {
                            comment = "Tricheur";
                        }
                        else
                        {
                            Console.WriteLine("Le résultat obtenu n'est pas possible, veuillez entrer vos vraies notes");
                        }
                        // affichage du message en fonction de la moyenne
                        Console.WriteLine($"{userName} vous avez obtenu une moyenne de {Math.Round(averageNote, 2)}, {comment}");
                    }
                    else
                    {
                        Console.WriteLine("Vous n'avez pas rentré de notes");
                    }
                }
                // sinon si c'est e, quitter
                else if (launchInput == "e")
                {
                    programExe = false;
                    break;
                }
                // sinon la saisie est incorrecte
                else
                {
                    Console.WriteLine("Saisie incorrecte");
                }
            }
        }
    }
}

