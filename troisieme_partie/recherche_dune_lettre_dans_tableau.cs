using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace Demarrage
{
    internal class Program
    {
        private static object lettre;

        static void Main(string[] args)
        {
            string saisie_utilisateur;
            int occurence;
            char[] lettres;
            char lettre_utilisateur;

            do
            {
                occurence = 0;
                Console.WriteLine("Saisissez une chaîne de caractères : ");
                saisie_utilisateur = Console.ReadLine();

                
                Console.WriteLine("Saisissez maintenant la lettre que vous souhaitez rechercher :");
                lettre_utilisateur = char.Parse(Console.ReadLine());
                lettres = saisie_utilisateur.ToCharArray();

                for (int i = 0; i < lettres.Length; i++)
                {
                    if (lettre_utilisateur == lettres[i])
                    {
                        occurence++;
                    }
                }

                Console.WriteLine($"Lettre '{lettre_utilisateur}' apparait {occurence} fois dans la chaîne.");

            } while (true);
        }

    }
}
