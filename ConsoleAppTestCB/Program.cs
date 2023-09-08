using Models.Client;
using Models.Compte;
using Service_BLL.Service_BLL_Cc;
using Service_BLL.Service_BLL_Ce;
using Service_BLL.Service_BLL_Client;
using System.Collections.ObjectModel;

namespace ConsoleAppTestCB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Transformer UML en C#
            // Dans le pp, c'est service (BLL) qu'on utilise, qui fait appel à DAO
            I_BLL_CompteEpargne eBll = new BLL_CompteEpargne();
            //  eBll.Depot(2, 100);

            // 1 Fonctionnalité Afficher liste des etudiants
            ObservableCollection<CompteEpargne> etudiants = eBll.GetAllCompteEpargneService();
          foreach(CompteEpargne m in etudiants)
            {
                Console.WriteLine(m);
            }

            Console.WriteLine("\n----------");

            /* 2 Afficher l'étudiant par l'ID
            Client eFind = eBll.GetClientByIdBll(1);
            Console.WriteLine(eFind);

            Console.WriteLine("\n----------");

            // 3 Ajout etudiant */
        }
    }
}