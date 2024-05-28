namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(4, 19);
            fractionLibrary.Fraction bf = new fractionLibrary.Fraction(7, 5);
            object cf = af.Plus(bf);
            Console.WriteLine(cf.ToString());


        
        }
    }
}