using System.Drawing;
using pointLibrary;

namespace app_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object ordosim;
            object abscisim;
            object origineSim;
            pointLibrary.Point premierPoint = new pointLibrary.Point(7, 7);
            Console.WriteLine(premierPoint.ToString());
            Console.Write("utilisation de la fonction mov avec les paramaitres 4 9");
            premierPoint.moov(4, 9);
            Console.WriteLine(premierPoint.ToString());
            Console.WriteLine("utilisation de la fonction simAbscisse");
            abscisim = premierPoint.simAbscisse();
            Console.WriteLine(abscisim.ToString());
            Console.WriteLine("utilisation de la fonction simOrdonnee");
            ordosim = premierPoint.simOrigine();
            Console.WriteLine(ordosim.ToString());
            Console.WriteLine("utilisation de la fonction simorigine");
            origineSim =  origineSim = premierPoint.simOrigine();
            Console.WriteLine(origineSim.ToString());
            Console.WriteLine("utilisation de la fonction permuter");
            premierPoint.permuter();
            Console.WriteLine(premierPoint.ToString());


        }
    }
}