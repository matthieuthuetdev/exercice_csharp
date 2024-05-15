using System.Security.Cryptography.X509Certificates;

namespace pointLibrary
{
    public class Point
    {
        private int abscisse;
        private int ordonnee;

        public Point(int abscisse, int ordonnee)
        {
            this.abscisse = abscisse;
            this.ordonnee = ordonnee;
        }
        public Point()
        {
            this.abscisse = 0;
            this.ordonnee = 0;
        }
    }
}