using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Compte
{
    public abstract class Compte
    {
        public int IdCompte { get; set; }
        public double Solde { get; set; }
        public String NumeroCompte { get; set; }
        public int NumClient { get; set; }

        public Compte()
        {
        }
        public Compte(double solde, string numeroCompte)
        {
            Solde = solde;
            NumeroCompte = numeroCompte;
        }

        public Compte(double solde, int numClient)
        {
            Solde = solde;
            NumClient = numClient;
        }

        public Compte(double solde, string numeroCompte, int numClient)
        {
            Solde = solde;
            NumeroCompte = numeroCompte;
            NumClient = numClient;
        }

        public Compte(int idCompte, double solde, string numeroCompte, int numClient)
        {
            IdCompte = idCompte;
            Solde = solde;
            NumeroCompte = numeroCompte;
            NumClient = numClient;
        }

        public void Depot(double montant)
        {
            this.Solde += montant;
        }

        //  retrait. N'oublions pas, on peut faire le retrait si la personne n'est pas à d�couvert
        public virtual bool Retrait(double montant)
        {
            Solde -= montant;

            return true;
        }


    }
}
