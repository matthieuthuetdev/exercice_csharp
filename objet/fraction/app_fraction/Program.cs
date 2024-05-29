using System.Runtime.InteropServices.ObjectiveC;

namespace app_fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            fractionLibrary.Fraction af = new fractionLibrary.Fraction(5, 7);
            fractionLibrary.Fraction bf = new fractionLibrary.Fraction(19, 5);
            Console.WriteLine("testes finales avant validation.");
            
            Console.WriteLine("création de deux fraction, la première : "+af.ToString()+"et la deuxième est "+ bf.ToString());
            object cf = af.Plus(bf);
            Console.WriteLine("teste de la fonction Plus, le résulta de la fonction est :"+ cf.ToString());
            object df = af.Moins(bf);
            Console.WriteLine("teste de la fonction Moins, le résulta de la fonction est :" + df.ToString());
            object ef = af.Multiplie(bf);
            Console.WriteLine("teste de la fonction Multiplie, le résulta de la fonction est :" + ef.ToString());
            object ff = af.Moins(bf);
            Console.WriteLine("teste de la fonction divise, le résulta de la fonction est :" + ff.ToString());
            af.Oppose();
            Console.WriteLine("teste de la fonction Opose, le résulta de la fonction est :" + af.ToString());
            af.Inverse();
            Console.WriteLine("teste de la fonction nverse, le résulta de la fonction est :" + af.ToString());



        }
    }
}