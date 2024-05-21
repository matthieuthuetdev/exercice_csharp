using System.Drawing;
using pointLibrary;

namespace app_point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            pointLibrary.Point premierPoint = new pointLibrary.Point(7, 7);
            Console.WriteLine(premierPoint.ToString());
        }
    }
}