namespace fractionLibrary
{
    public class Fraction
    {
        private int Numerateur;
        private int Denominateur;
        public Fraction ( int numerateur, int denominateur)
        {
            this.Numerateur = numerateur;
            this.Denominateur = denominateur;
        }
        public void Oppose()
        {
            this.Numerateur = this.Numerateur * -1; 
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
                return "erreure : aucun nombre ne peut être diviser par 0";
            }
            else
            {
                return "la fraction est égale à : " + this.Numerateur + "/" + this.Denominateur;
            }
        }
    }
}