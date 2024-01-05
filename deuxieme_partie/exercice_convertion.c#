using System;

namespace demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string saisie;
            double km, mile;

            do
            {
                Console.WriteLine("Saisissez un nombre de kilomètres entre 0.01 et 1 000 000 (ou 'q' pour quitter) :");
                saisie = Console.ReadLine();

            } while (!(double.TryParse(saisie, out km) && (km >= 0.01 && km <= 1000000) || saisie.ToLower() == "q"));

            if (saisie.ToLower() != "q")
            {
                mile = km / 1.609;
                Console.WriteLine($"La conversion de {km} kilomètres en miles est : {mile:F2} miles");
            }
        }
    }
}