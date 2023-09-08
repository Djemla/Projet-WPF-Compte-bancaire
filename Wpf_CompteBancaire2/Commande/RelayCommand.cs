using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Wpf_CompteBancaire2.Commande
{
    internal class RelayCommand : ICommand // // du systeme: Icommande est l'interface qui fournit les evenements liés aux bouttons. 
                                           // Un bouton de nature produit un evenement. En cliquant sur le bouton, l'evenement derriere peut être exucuté ou pas. Ici l'evement est si ça peut ouvrir une fenêtre (= true => bool), et affiche la fenêtre (execute method).
                                           // C'est pour celà que cette interface a 2 propriétés: Action qui retourne un void (execute methode), et predicate un bool (can execute)
    {
        public event EventHandler? CanExecuteChanged; // Apparait avec l'interface Icommand
                                                      // Interpretation selon moi: Si l'evenement n'est 
                                                      // Creer 2 propriétés: Action et predicate



        private Action<object> Excute { get; set; } // METHOD qui retourne un void. Prend un objet
        private Predicate<object> CanExcute { get; set; } // // METHOD qui retourne un boolean. Prend un objet
        // Ces 2 propriétés (ou méthodes) ont été crées pcq lorsqu'on invoque les 2 méthodes ci-dessous, l'un retourne un void et l'autre un boolean.
        // Private car ne peuvent qu'êtres utilisées dans cette classe



        // Creation du constructeur qui regroupe ces 2 methodes. On aura besoin de cette classe instanciée plustard dans le MainViewModel, pour renseigner les 2 méthodes à definir dans les parametres du constructeur.
        public RelayCommand(Action<object> ExcuteMethod, Predicate<object> CanExcuteMethod)
        {
            Excute = ExcuteMethod;
            CanExcute = CanExcuteMethod;
        }





        public bool CanExecute(object? parameter)
        {
            return CanExcute(parameter); // Modifié: Pour dire qu'il peut executer la page qu'on va spécifié
        }

        public void Execute(object? parameter)
        {
            Excute(parameter); // Modifié: Pour dire qu'il execute la page qu'on va spécifié ici
        }

        // Si dans notre vue on invoque une commande, cette commande va executer ces 2 méthodes simultanement
    }
}
