namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(2,4);
            Console.WriteLine("la fraction af est égale à :");
            Console.WriteLine(af.ToString());
            fractionLibrary.Fraction bf = new fractionLibrary.Fraction(3,4);
            Console.WriteLine("la fraction bf est égale à :");
            Console.WriteLine(bf.ToString());
            object cf = af.Divise(bf);
            Console.WriteLine("le résulta de la division deux fraction présédante est de :");
            Console.WriteLine(cf.ToString());
            Console.WriteLine("vérification que les deux fraction du début n'ait pas bouger a cause de la fonction multiplier");
            Console.WriteLine(af.ToString());
            Console.WriteLine(bf.ToString());


        
        }
    }
}