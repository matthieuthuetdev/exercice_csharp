namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(4, 19);
            Console.WriteLine(af.ToString());
            fractionLibrary.Fraction bf = new fractionLibrary.Fraction(7, 5);
            Console.WriteLine(bf.ToString());
            object cf = af.Multiplie(bf);
            Console.WriteLine(cf.ToString());
            Console.WriteLine(af);


        
        }
    }
}