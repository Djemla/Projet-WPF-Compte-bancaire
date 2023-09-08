using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Compte
{
    public class CompteCourant : Compte
    {
        public int DecouvertAutorise { get; set; } // =100; Juste pour voir ce que la liste va m'afficger avec le getAllCompte

        public CompteCourant()
        {
            DecouvertAutorise = -100;
        }

        public CompteCourant(double solde, string numeroCompte) : base(solde, numeroCompte)
        {
            DecouvertAutorise = -100;
        }

        public CompteCourant(double solde, int NumClient) : base(solde, NumClient)
        {
            DecouvertAutorise = -100;
        }

        public CompteCourant(double solde, string numeroCompte, int numClient) : base(solde, numeroCompte, numClient)
        {
            DecouvertAutorise = -100;
        }

        public CompteCourant(double solde, string numeroCompte, int decouvertAutorise, int numClient) : base(solde, numeroCompte, numClient)
        {
            DecouvertAutorise = decouvertAutorise;
        }

        public CompteCourant(int idCompte, double solde, string numeroCompte, int decouvertAutorise, int numClient) : base(idCompte, solde, numeroCompte, numClient)
        {
            DecouvertAutorise = decouvertAutorise;
        }

        // Methodes
        public override bool Retrait(double montant)
        {
            if (this.Solde - montant >= DecouvertAutorise)
            { // faut que la diff soit supérieur au découvert (20>-10)
                this.Solde -= montant;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool Virement(double montant, CompteCourant debiteur)
        {
            bool verif = this.Retrait(montant); // This ici fait reference à l'instanciation de la classe qui appelle la méthode retirer
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

        public override string ToString()
        {
            return $"Id compte: {IdCompte}, Num client: {NumClient}, Solde: {Solde}, Decouvert autorise: {DecouvertAutorise}, Num compte: {NumeroCompte}";
        }
    }
}
