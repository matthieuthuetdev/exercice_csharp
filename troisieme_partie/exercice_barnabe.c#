using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Mail;

namespace Demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double solde , depense , nouveau_solde , solde_iniciale ;
            int nombre_de_magasin;
            solde = 0;
            
            do
            {
                Console.WriteLine("saisisez le montant que barnabé posède avant de faire ces cources :");
                solde_iniciale = double.Parse(Console.ReadLine());
            }while(solde_iniciale < 1);
            solde = solde_iniciale;
            
            nombre_de_magasin = 0;
            while (solde > 1)
            {
                nombre_de_magasin +=1;
                depense = solde / 2 + 1;
                solde = solde - depense;
                }
            
            nombre_de_magasin++;
            depense = solde;
            solde -= depense;
            Console.WriteLine($"avec un solde iniciale de {solde_iniciale} il peut effectuer des achat dans {nombre_de_magasin} magasin.");
        }

    }
}