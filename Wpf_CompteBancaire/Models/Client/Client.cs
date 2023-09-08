using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Client
{
    public class Client
    {

        // Propriétés automatiques: nom, prénom, adresse, code postal, ville, téléphone;
        public int Id { get; set; } = 0;
        public String Nom { get; set; }
        public String Prenom { get; set; }
        public String Adresse { get; set; }
        public int CodePostal { get; set; }
        public String Ville { get; set; }
        public string Telephone { get; set; }

        // Constructeur
        public Client() { }

        public Client(int id, string nom, string prenom, string adresse, int codePostal, string ville, string telephone)
        {
            Id = id;
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = telephone;
        }

        public Client(string nom, string prenom, string adresse, int codePostal, string ville, string telephone)
        {
            Nom = nom;
            Prenom = prenom;
            Adresse = adresse;
            CodePostal = codePostal;
            Ville = ville;
            Telephone = telephone;
            // Id++; Pas besoin ici je pense, vu qu'il est incrementer automatiquement dans le SQL
        }

        public override string ToString()
        {
            return $"Id: {Id} Nom: {Nom}, Prenom: {Prenom}, Adresse: {Adresse}, CodePostal: {CodePostal}, Ville: {Ville}, Telephone: {Telephone}";
        }
    }
}
