using System.Formats.Asn1;
using System.Runtime.InteropServices;
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
        public bool moov(int nouvelleAbscisse, int nouvelleOrdonnee)
        {
            this.abscisse = nouvelleAbscisse;
            this.ordonnee = nouvelleOrdonnee;
            return true;
        }
        public bool simAbscisse()
        {
            this.abscisse = this.abscisse * -1;
            return true;
        }
        public override string ToString()
        {
            return "les cordonnée du point sont : X"+ abscisse+"Y"+ordonnee;
        }
    }
}