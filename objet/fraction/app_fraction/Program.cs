namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(4, 7);
            fractionLibrary.Fraction bf = new fractionLibrary.Fraction(4, 1);
            fractionLibrary.Fraction cf = new fractionLibrary.Fraction(4, 0);
            fractionLibrary.Fraction df = new fractionLibrary.Fraction(1, 4);
            Console.WriteLine(af.ToString());
            Console.WriteLine(bf.ToString());
            Console.WriteLine(cf.ToString());
            Console.WriteLine(df.ToString());
        }
    }
}