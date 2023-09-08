using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Compte
{
    public class CompteEpargne : Compte
    {
        public double TauxEpargne { get; set; } // = 0.03; Juste pour voir ce que la liste va m'afficger avec le getAllCompte
        public CompteEpargne()
        {
            TauxEpargne = 0.03;
        }
        public CompteEpargne(double solde, string numeroCompte) : base(solde, numeroCompte)
        {
            TauxEpargne = 0.03;
        }

        public CompteEpargne(double solde, int numClient) : base(solde, numClient)
        {
            TauxEpargne = 0.03;
        }

        public CompteEpargne(double solde, string numeroCompte, int numClient) : base(solde, numeroCompte, numClient)
        {
            TauxEpargne = 0.03;
        }

        public CompteEpargne(double solde, string numeroCompte, double tauxEpargne, int numClient) : base(solde, numeroCompte, numClient)
        {
            TauxEpargne = tauxEpargne;
        }

        public CompteEpargne(int idCompte, double solde, string numeroCompte, int numClient) : base(idCompte, solde, numeroCompte, numClient)
        {
            TauxEpargne = 0.03;
        }
        public CompteEpargne(int idCompte, double solde, string numeroCompte, int numClient, double tauxEpargne) : base(idCompte, solde, numeroCompte, numClient)
        {
            TauxEpargne = tauxEpargne;
        }

        public override bool Retrait(double montant)
        {
            if (Solde - montant > 0)
            { // faut que la diff soit supérieur à 0
                Solde -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Virement(double montant, CompteEpargne debiteur)
        {
            bool verif = this.Retrait(montant);
            if (verif)
            {
                debiteur.Depot(montant); // debiteur appelle la méthode dépot de la classe Compte
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculInteret(double duree)
        {
            double interet = this.Solde * this.TauxEpargne * duree;
            this.Solde = Solde + interet;
            return interet;
        }

        public override string ToString()
        {
            return $"Id compte: {IdCompte}, Num client: {NumClient}, Solde: {Solde}, Taux d'epargne: {TauxEpargne}, Num compte: {NumeroCompte}";
        }
    }
}
