namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(4, 12);
           
            af.rediure();
            Console.WriteLine(af.ToString());

        
        }
    }
}