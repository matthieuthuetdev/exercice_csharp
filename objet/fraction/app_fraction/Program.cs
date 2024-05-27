namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(4, 12);
            fractionLibrary.Fraction bf = new fractionLibrary.Fraction(7, 5);
            af.Plus(bf);
            Console.WriteLine(af.ToString());


        
        }
    }
}