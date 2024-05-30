using System.Drawing;

namespace fractionLibrary
{
    public class Fraction
    {
        private int numerateur;
        private int denominateur;

        public Fraction(int numerateur, int denominateur)
        {
            this.numerateur = numerateur;
            this.denominateur = denominateur;
        }

        public int GetPgcd()
        {
            int a = this.numerateur;
            int b = this.denominateur;
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
            this.numerateur *= -1;
        }

        public void Inverse()
        {
            int newnumerateur = this.denominateur;
            this.denominateur = this.numerateur;
            this.numerateur = newnumerateur;

        }

        private void Reduire()
        {
            int pgcd = GetPgcd();
            this.numerateur /= pgcd;
            this.denominateur /= pgcd;
            this.Signe();
        }

        public Fraction Plus(Fraction fplus)
        {
            int numerateur1 = this.numerateur;
            int denominateur1 = this.denominateur;
            int numerateur2 = fplus.numerateur;
            int denominateur2 = fplus.denominateur;

            int newnumerateur;
            int newdenominateur;
            newnumerateur = numerateur1 * denominateur2 + numerateur2 * denominateur1;
            newdenominateur = denominateur1 * denominateur2;
            

            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;

        }

        public Fraction Moins(Fraction fmoins)
        {
            int numerateur1 = this.numerateur;
            int denominateur1 = this.denominateur;
            int numerateur2 = fmoins.numerateur;
            int denominateur2 = fmoins.denominateur;

            int newnumerateur;
            int newdenominateur;

            
                newnumerateur = numerateur1 * denominateur2 - numerateur2 * denominateur1;
                newdenominateur = denominateur1 * denominateur2;
            

            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;

        }
        public Fraction Multiplie( Fraction fmultiplie)
        {
            int newnumerateur = this.numerateur * fmultiplie.numerateur;
            int newdenominateur = this.denominateur * fmultiplie.denominateur;
            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;

        }
        public Fraction Divise(Fraction fmultiplie)
        {
            int newnumerateur = this.numerateur * fmultiplie.denominateur;
            int newdenominateur = this.denominateur * fmultiplie.numerateur;
            Fraction newFraction = new Fraction(newnumerateur, newdenominateur);
            newFraction.Signe();
            newFraction.Reduire();
            return newFraction;
        }
        private void Signe()
        {
            if (this.numerateur < 0 && this.denominateur < 0)
            {
                this.numerateur *= -1;
                this.denominateur *= -1;
            }
        }

        public override string ToString()
        {
            if (this.denominateur == 1)
            {
                return this.numerateur+"";
            }
            else
            {
                return this.numerateur + "/" + this.denominateur;
            }
        }
    }
}