using System.Runtime.CompilerServices;

namespace compte_library
{
    public class Compte
    {
        private int NumeroDeCompte;
        private string NomDuProprietaireDuCompte;
        private double SoldeDuCompte;
        private double DecouvertAutorise;

        public Compte(int numeroDeCompte, string nomDuProprietaireDuCompte, double soldeDuCompte, double decouvertAutorise)
        {
            NumeroDeCompte = numeroDeCompte;
            NomDuProprietaireDuCompte = nomDuProprietaireDuCompte;
            SoldeDuCompte = soldeDuCompte;
            DecouvertAutorise = decouvertAutorise;
        }

        public void Crediter(double montant)
        { 
            SoldeDuCompte += montant > 0 ? montant : 0;
        }

        public bool Debiter(double montant)
        {
            if (SoldeDuCompte-montant>=this.DecouvertAutorise)
            {
                SoldeDuCompte -= montant > 0 ? montant : 0;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Transferer(Compte compteACrediter, double montant)
        {
            if (Debiter(montant))
            {
                compteACrediter.Crediter(montant);
                return true;
            }
            else
            {
                return false;
            }
        }
        public override string ToString()
        {
            return "ce compte a pour numero " + this.NumeroDeCompte + "\n il appartient à " + this.NomDuProprietaireDuCompte + "\n sont solde est de " + this.SoldeDuCompte + "\n et sont découvert autoriser est de " + this.DecouvertAutorise+"\n \n" ;
        }
    }
}