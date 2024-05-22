﻿using System.Data.SqlTypes;
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
        public void moov(int nouvelleAbscisse, int nouvelleOrdonnee)
        {
            this.abscisse = nouvelleAbscisse;
            this.ordonnee = nouvelleOrdonnee;
            
        }
        public Point simAbscisse()
        {
            Point abscisim = new Point(this.abscisse * -1, this.ordonnee);
            return abscisim;
        }
        public Point simOrdonnee()
        {
            Point ordosim = new Point(this.abscisse, this.ordonnee * -1);
            return ordosim;
        }
        public object simOrigine()
        {
            Point origineSim = new Point(this.abscisse * -1, this.ordonnee * -1);
            return origineSim;
        }
        public void permuter()
        {
            this.abscisse = this.ordonnee;
            this.ordonnee = this.abscisse;
        }
        public override string ToString()
        {
            return "les cordonnée du point sont : X"+ abscisse+"Y"+ordonnee;
        }
    }
}