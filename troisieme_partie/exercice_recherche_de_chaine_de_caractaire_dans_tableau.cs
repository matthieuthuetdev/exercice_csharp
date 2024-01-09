using Microsoft.Win32.SafeHandles;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace Demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie_utilisateur;
            char[] lettres;
            int nombre_de_lettres;
            do
            {
                Console.WriteLine("Saisissez une chaîne de caractères : ");
                saisie_utilisateur = Console.ReadLine();

                lettres = saisie_utilisateur.ToCharArray();
            for (int i = 0; i < lettres.Length; i++)
            {
                if(lettres[i] = char.Parse(saisie_utilisateur))
                    {
                        nombre_de_lettres++;
                    }
            }

                Console.WriteLine(nombre_de_lettres);
                
            
            } while (saisie_utilisateur != "quitter");
        }

    }
}