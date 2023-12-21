 namespace demarrage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nombre_annee;
            double montant;
            double interet;
            double interait_simple;
            double interet_composer;
            Console.WriteLine("saisisez le nombre d'année : ");
            nombre_annee = int.Parse(Console.ReadLine());
            Console.WriteLine("saisisez le montant : ");
            montant = int.Parse(Console.ReadLine());
            Console.WriteLine("saisisez l'interet : ");
            interet = int.Parse(Console.ReadLine());

            interait_simple = montant * (1 + nombre_annee * interet);
            interet_composer = montant*Math.Pow(1+interet,nombre_annee);
            Console.WriteLine("avec un interet simple la valeure est de :" + interait_simple);
            Console.WriteLine("avec un interet composer la valeure est de :" + interet_composer);

        }

    }
}