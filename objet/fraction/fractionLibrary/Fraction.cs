using System.Drawing;

namespace fractionLibrary
{
    public class Fraction
    {
        private int numerateur;
        private int Denominateur;

        public Fraction(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.Denominateur = denominateur;
        }

        public int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.Denominateur;
            int pgcd = 1;

            if (a != 0 && b != 0)
            {
                if (a < 0) a = -a;
                if (b < 0) b = -b;

                while (a != b)
                {
                    if (a < b)
                    {
                        b = b - a;
                    }
                    else
                    {
                        a = a - b;
                    }
                }

                pgcd = a;
            }

            return pgcd;
        }

        public void Oppose()
        {
            this.numerateur = this.numerateur * -1;
        }

        public void Inverse()
        {
            int newnumerateur = this.Denominateur;
            int newDenominateur = this.numerateur;
            this.numerateur = newnumerateur;
            this.Denominateur = newDenominateur;
        }

        public void Reduire()
        {
            int pgcd = GetPgcd();
            this.numerateur /= pgcd;
            this.Denominateur /= pgcd;
            this.Signe();
        }

        public Fraction Plus(Fraction fplus)
        {
            int numerateur1 = this.numerateur;
            int denominateur1 = this.Denominateur;
            int numerateur2 = fplus.numerateur;
            int denominateur2 = fplus.Denominateur;

            int newnumerateur;
            int newdenominateur;

            if (denominateur1 == denominateur2)
            {
                newnumerateur = numerateur1 + numerateur2;
                newdenominateur = denominateur1;
            }
            else
            {
                newnumerateur = numerateur1 * denominateur2 + numerateur2 * denominateur1;
                newdenominateur = denominateur1 * denominateur2;
            }

            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;

        }

        public Fraction Moins(Fraction fmoins)
        {
            int numerateur1 = this.numerateur;
            int denominateur1 = this.Denominateur;
            int numerateur2 = fmoins.numerateur;
            int denominateur2 = fmoins.Denominateur;

            int newnumerateur;
            int newdenominateur;

            if (denominateur1 == denominateur2)
            {
                newnumerateur = numerateur1 - numerateur2;
                newdenominateur = denominateur1;
            }
            else
            {
                newnumerateur = numerateur1 * denominateur2 - numerateur2 * denominateur1;
                newdenominateur = denominateur1 * denominateur2;
            }

            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;

        }
        public Fraction Multiplie( Fraction fmultiplie)
        {
            int newnumerateur = this.numerateur * fmultiplie.numerateur;
            int newdenominateur = this.Denominateur * fmultiplie.Denominateur;
            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;

        }
        public Fraction Divise(Fraction fmultiplie)
        {
            int newnumerateur = this.numerateur * fmultiplie.Denominateur;
            int newdenominateur = this.Denominateur * fmultiplie.numerateur;
            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;
        }
        private void Signe()
        {
            if (this.numerateur < 0 && this.Denominateur < 0)
            {
                this.numerateur *= -1;
                this.Denominateur *= -1;
            }
        }

        public override string ToString()
        {
            if (this.numerateur == 0)
            {
                return "la fraction est égale à : 0 \n";
            }
            else if (this.Denominateur == 1)
            {
                return "la fraction est égale à : " + this.numerateur;
            }
            else if (this.Denominateur == 0)
            {
                return "erreur : aucun nombre ne peut être diviser par 0";
            }
            else
            {
                return this.numerateur + "/" + this.Denominateur;
            }
        }
    }
}