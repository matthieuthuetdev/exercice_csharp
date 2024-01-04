using System;

namespace Demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, essai = 0, saisie;
            Random random = new Random();
            n = random.Next(0, 100);

            do
            {
                Console.WriteLine("Saisissez un nombre entre 0 et 100 pour essayer de deviner le nombre correct :");
                saisie = Convert.ToInt32(Console.ReadLine());
                essai++;

                if (saisie < n)
                {
                    Console.WriteLine("C'est plus !");
                }
                else if (saisie > n)
                {
                    Console.WriteLine("C'est moins !");
                }
                else
                {
                    Console.WriteLine($"Bravo, vous avez trouvé le bon nombre en {essai} essais.");
                }

            } while (saisie != n);
        }
    }
}