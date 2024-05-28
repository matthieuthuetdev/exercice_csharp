namespace fractionLibrary
{
    public class Fraction
    {
        private int Numerateur;
        private int Denominateur;

        public Fraction(int numerateur, int denominateur)
        {
            this.Numerateur = numerateur;
            this.Denominateur = denominateur;
        }

        public int GetPgcd()
        {
            int a = this.Numerateur;
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
            this.Numerateur = this.Numerateur * -1;
        }

        public void Inverse()
        {
            int newNumerateur = this.Denominateur;
            int newDenominateur = this.Numerateur;
            this.Numerateur = newNumerateur;
            this.Denominateur = newDenominateur;
        }
        public void rediure()
        {
            int pgcd = GetPgcd();
            this.Numerateur /=pgcd;
            this.Denominateur /=pgcd;
            this.Signe();
            
        }
        public Fraction Plus(Fraction fplus)
        {
            int numerateur1 = this.Numerateur;
            int denominateur1 = this.Denominateur;
            int numerateur2 = fplus.Numerateur;
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

            return new Fraction(newnumerateur, newdenominateur);
        }
        public void Signe()
        {
            if (this.Numerateur < 0 && this.Numerateur < 0)
            {
                this.Numerateur *= -1;
                this.Denominateur *= -1;
            }
        }
        public override string ToString()
        {
            if (this.Numerateur == 0)
            {
                return "la fraction est égale à : 0 \n";
            }
            else if (this.Denominateur == 1)
            {
                return "la fraction est égale à : " + this.Numerateur;
            }
            else if (this.Denominateur == 0)
            {
                return "erreur : aucun nombre ne peut être diviser par 0";
            }
            else
            {
                int pgcd = GetPgcd();
                this.Numerateur /= pgcd;
                this.Denominateur /= pgcd;

                return "la fraction est égale à : " + this.Numerateur + "/" + this.Denominateur;
            }
        }
    }
}
