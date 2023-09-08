using Dao_DAL.Dao_DAL_Client;
using Models.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using Wpf_CompteBancaire2.Commande;

namespace Wpf_CompteBancaire2.Views_Models.Each_Model_Menu_Client { 

    // PAS BESOIN DE CETTE CLASSE. J'ai voulu contourner en créant directement les methodes ici pour Binding dans les boutons, mais pas évident/
    // Car je ne peut pas utiliser text.clear pour effacer les saisies de la vue et remettre le curseur au début.
    // C'est mieux que je detaille les boutons dans le window


    public class Add_Update_Delete_Find
    {
        public I_Menu_Client_Model mCM = new Menu_Client_Model();
        AjoutOk messageAjoutOk = MessageBoxAjoutOk;

        public ICommand AddClient { get; set; } // C'est cette propriété qu'on va aposer sur le bouton ajouter (binding)
        public ICommand UpdateClient { get; set; }
        public ICommand DeleteClient { get; set; }
        public ICommand FindByIdClient { get; set; }


        public string? tbxNom { get; set; }
        public string? tbxPrenom { get; set; }
        public string? tbxAdresse { get; set; }
        public int? tbxCodePostal { get; set; }
        public string? tbxVille { get; set; }
        public string? tbxTelephone { get; set; }


        public Add_Update_Delete_Find()
        {
            AddClient = new RelayCommand(AddCli, CanAddCli);
            UpdateClient = new RelayCommand(UpdateCli, CanUpdateCli);
            DeleteClient = new RelayCommand(DeleteCli, CanDeleteCli);
            FindByIdClient = new RelayCommand(FinbyIdCli, CanFindByIdCli);
        }

        private bool CanAddCli(object obj)
        {
            return true;
        }

        private void AddCli(object obj)
        {
            Client p1 = new Client()
            {

                Nom = tbxNom,
                Prenom = tbxPrenom,
                Adresse = tbxAdresse,
                CodePostal = Convert.ToInt32(tbxCodePostal),
                Ville = tbxVille,
                Telephone = tbxTelephone
            };

            mCM.AddClientBll(p1, messageAjoutOk);

            // On peut mettre directement le messageBox ixi, vu que ça ne necessite pas une condition.
            // En plus ça évite de créer les methodes et délégués inutilement
            
/*
            tbxNom.Clear();
            tbxPrenom.Clear();
            tbxAdresse.Clear();
            tbxCodePostal.Clear();
            tbxVille.Clear();
            tbxTelephone.Clear();
            tbxNom.Focus(); */
        }

        private bool CanUpdateCli(object obj)
        {
            return true;
        }

        private void UpdateCli(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanDeleteCli(object obj)
        {
            return true;
        }

        private void DeleteCli(object obj)
        {
            throw new NotImplementedException();
        }

        private bool CanFindByIdCli(object obj)
        {
            return true;
        }

        private void FinbyIdCli(object obj)
        {
            throw new NotImplementedException();
        }


        // Message liés aux délégués
        public static void MessageBoxAjoutOk()
        {
            MessageBox.Show("Ajout Ok");
        }
    }
}
