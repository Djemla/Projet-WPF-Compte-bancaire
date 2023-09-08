using Models.Compte;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Dao_DAL.Dao_DAL_Ce
{
    public class DAL_CompteEpargne : I_DAL_CompteEpargne
    {
        //public ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>(); // On crée une liste où notre resultat sera stockée
       // public List<CompteEpargne> liste = new List<CompteEpargne>();
        // Definir la chaine de connection qui contient les infos de la bd
        // cad nom du serveur (.) ; nom de la bdd (db_cour_ado) ; identifiant (sa); mot de passe(Admin@123)
        private string connectionString = "Data Source =.; Initial Catalog =compte_bancaire; User ID=sa; Password=Admin@123";  // Pour lui dire en local, on met le point pour eviter d'écrire tout le nom du serveur (LAPTOP-FMI...)

        // Declaration d'un champs pour la connection
        private SqlConnection conn = null; // type SqlConnection pour la connection



        public int AddCompteEpargneDal(CompteEpargne cli)
        {
            try
            {
                // Ouvrir la connexion
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Formuler la requete
                string req = "insert into compte_epargne (solde_e, numero_e, tauxEpargne_e, num_client_e) values (@solde, @numero, @tauxEpargne, @numClient)";

                // prepare le bus pour envoyer la requete et la connexion VERS SQL à traver le bus
                SqlCommand commande = new SqlCommand(req, conn);

                // Assignation des parametres
                commande.Parameters.Add(new SqlParameter("solde", cli.Solde));
                commande.Parameters.Add(new SqlParameter("numero", cli.NumeroCompte));
                commande.Parameters.Add(new SqlParameter("tauxEpargne", cli.TauxEpargne));
                commande.Parameters.Add(new SqlParameter("numClient", cli.NumClient));


                // Envoi de la requete pour l'executer
                int lignesAffectees = commande.ExecuteNonQuery(); // Je stoque son resultat dans un int car ca sera mon retour

                return lignesAffectees; // Si tout va bien, il me retourne le nombre de lignes affectées


            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();

                conn.Dispose(); // Liberer les ressources
            }

            return 0;
        }

        public int DeleteCompteEpargneDal(int id)
        {
            try
            {
                // Ouverture de la connexion
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Faire la requete
                string req = "delete from compte_epargne where num_client_e = @Id";

                // Prepare le bus qui ira avec la requête
                SqlCommand commande = new SqlCommand(req, conn);

                // Assignation des parametres
                commande.Parameters.Add(new SqlParameter("Id", id));

                // Envoie de la requete vers SQL
                int lignesSupprimées = commande.ExecuteNonQuery();

                return lignesSupprimées;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();

                conn.Dispose(); // Liberer les ressources
            }
            return 0;
        }

        /*    public int Depot(int idClient, double montant) // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.
            {
                try
                {

                    // Tout d'abord on veut qu'il recupere le solde correspondant à l'ID client

                    // Etape 1 Ouverture de la connexion
                    conn = new SqlConnection(connectionString);
                    conn.Open();

                    // Etape 2: Fprmuler la requete SQL
                    String req = "SELECT*FROM compte_epargne where num_client_e=@Id";


                    // Etape 3: Preparer le bus
                    SqlCommand commande = new SqlCommand(req, conn);

                    // Etape 4: Assigner les parametres et envoyer la requete pour recuperer le resultat
                    commande.Parameters.Add(new SqlParameter("Id", idClient));
                    SqlDataReader rd = commande.ExecuteReader();

                    rd.Read(); // Vu que c'est une seule ligne ici à lire, par besoin du while

                    double solde1 = rd.GetDouble(1);
                    int id1 = rd.GetInt32(4);

                    // instancier un client avec ces valeurs
                    CompteEpargne ceOut = new CompteEpargne(solde1, id1);

                    // Etape 5: J'applique la méthode depot cc de ce client. Avec cette méthode, il y'aura une entrée d'argent.
                    ceOut.Depot(montant);

                    // Entrée d'argent => solde modifié => update solde
                    // Après le dépot, le solde sera donc modifié. On fera une nouvelle requête update pour modifier dans la table.


                    //Etape 6: Ecrire la nouvelle requete SQL pour modifier le solde dans la base SQL
                    String req2 = "update compte_epargne set solde_e=@solde2 where num_client_e_e=@Id2";


                    //Etape 7: preparer le bus
                    SqlCommand commande2 = new SqlCommand(req2, conn);

                    // Etape 8: Assigner les parametres et envoyer la requête
                    commande2.Parameters.Add(new SqlParameter("solde2", ceOut.Solde));
                    commande2.Parameters.Add(new SqlParameter("Id2", ceOut.NumClient));

                    int lignesModifiées = commande2.ExecuteNonQuery();

                    return lignesModifiées;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // e.printStackTrace();
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
                return 0;
            } */

        public ObservableCollection<CompteEpargne> GetAllCompteEpargneDal()
          //  public List<CompteEpargne> GetAllCompteEpargneDal()
        {
            try // Le try est le programme a executer normalement. Et s'il n'est pas executé, il va reoturner sur null tout à la fin de la boucle
            {

                // Etape 1: Ouverture de la connexion (Instancier un objet de type sqlConnection et lui specifier la chaine de connection)
                conn = new SqlConnection(connectionString); // ou SqlConnection conn = new SqlConnection(connectionString); Mais conn est déjà declaré plus haut

                // Etape 2: Ouverture de la connexion
                conn.Open();

                // Etape3: Ecrire la requête SQL
                string req = "select * from compte_epargne";

                // Etape 4: Preparer le bus qui va Recuperer la requete SQL vers c#. C'est le bus qui va transporter la requête. le bus commande est de type SqlCommand)
                SqlCommand commande = new SqlCommand(req, conn); // bus

                // Etape 5 Executer la requête SQL et recuperer le résultat (appel d'une des méthodes de l'objet SqlCommand)
                SqlDataReader rd = commande.ExecuteReader();     // ExecureNonQuery pour les commandes qui ne retournent pas de resultat 'insert, update, delete)
                                                                 // SqlDataReader

                ObservableCollection<CompteEpargne> liste = new ObservableCollection<CompteEpargne>();
                // List<CompteEpargne> liste = new List<CompteEpargne>();

                while (rd.Read()) // Parcourir l'objet SQLDatareader en utilisant sa méthode Read() pour deplacer le curseur à chaque itteration
                {
                    int id1 = rd.GetInt32(0);
                    double solde = rd.GetDouble(1); // Lorsqu'on recupere rd["ID"], il recupere en type objet, cad type string. Faurt donc le convertir
                    string numeroCompte = rd.GetString(2); // On peut recuperer via le getX . Le X ici est le type de la colonne et a utilise un indexeur de colonne. l'indexeur 1 correspond à la colonne Nom
                    double tauxEpargne = rd.GetDouble(3);
                    int numClient = rd.GetInt32(4);


                    // Instancier un etudiant avec ces valeurs
                    CompteEpargne cliOut = new CompteEpargne(id1, solde, numeroCompte, numClient, tauxEpargne);

                    // Ajouter cet etudiant dans la liste
                    liste.Add(cliOut);


                }


                return liste; // Soit on a la liste complete

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                // Fermer la connexion
                conn?.Close(); // ?=operateur nulllable; Si la connection est nulle, ne va pas appeler la méthode close, sinon close

                // Liberer les ressources
                conn.Dispose();
            }

            return null;
        }

        public ObservableCollection<CompteEpargne> GetCompteEpargneByClientId(int clientId)
          //  public List<CompteEpargne> GetCompteEpargneByClientId(int clientId)
        {
            try
            {
                // Ouverture de la connection
                conn = new SqlConnection(connectionString);
                conn.Open();

                // formuler la requete à faire
                string req = "select * from compte_epargne where num_client_e = @Id";

                // Preparer le bus qui va envoyer la requete
                SqlCommand commande = new SqlCommand(req, conn); // Commande ici remplace le ps

                // Assignation des valeurs aux paramètres de la requète sql
                // ps.setInt(1, id);

                commande.Parameters.Add(new SqlParameter("Id", clientId));

                // string commande.Parameters.Add("id_e", SqlDbType.VarChar, 80).Value = "toasters";

                // Envoyer la requete vers sql
                SqlDataReader rd = commande.ExecuteReader(); // Commande ici remplace le ps


                ObservableCollection<CompteEpargne> listeId = new ObservableCollection<CompteEpargne>();
              // List<CompteEpargne> listeId = new List<CompteEpargne>();

                while (rd.Read()) // Parcourir la table sql et recuperer les informations
                {
                    int id1 = rd.GetInt32(0);
                    double solde = rd.GetDouble(1); // Lorsqu'on recupere rd["ID"], il recupere en type objet, cad type string. Faurt donc le convertir
                    string numeroCompte = rd.GetString(2); // On peut recuperer via le getX . Le X ici est le type de la colonne et a utilise un indexeur de colonne. l'indexeur 1 correspond à la colonne Nom
                    double tauxEpargne = rd.GetDouble(3);
                    int numClient = rd.GetInt32(4);


                    CompteEpargne eOut = new CompteEpargne(id1, solde, numeroCompte, numClient, tauxEpargne);
                    listeId.Add(eOut);


                }

                return listeId;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();

                conn.Dispose(); // Liberer les ressources
            }

            return null;
        }

        public ObservableCollection<CompteEpargne> GetCompteEpargneById(int id)
        {
            try
            {
                // Ouverture de la connection
                conn = new SqlConnection(connectionString);
                conn.Open();

                // formuler la requete à faire
                string req = "select * from compte_epargne where idCe_e = @Id";

                // Preparer le bus qui va envoyer la requete
                SqlCommand commande = new SqlCommand(req, conn); // Commande ici remplace le ps

                // Assignation des valeurs aux paramètres de la requète sql
                // ps.setInt(1, id);

                commande.Parameters.Add(new SqlParameter("Id", id));

                // string commande.Parameters.Add("id_e", SqlDbType.VarChar, 80).Value = "toasters";

                // Envoyer la requete vers sql
                SqlDataReader rd = commande.ExecuteReader(); // Commande ici remplace le ps

                ObservableCollection<CompteEpargne> listeId = new ObservableCollection<CompteEpargne>();
                

                while (rd.Read()) // Parcourir la table sql et recuperer les informations
                {
                    int id1 = rd.GetInt32(0);
                    double solde = rd.GetDouble(1); // Lorsqu'on recupere rd["ID"], il recupere en type objet, cad type string. Faurt donc le convertir
                    string numeroCompte = rd.GetString(2); // On peut recuperer via le getX . Le X ici est le type de la colonne et a utilise un indexeur de colonne. l'indexeur 1 correspond à la colonne Nom
                    double tauxEpargne = rd.GetDouble(3);
                    int numClient = rd.GetInt32(4);

                    CompteEpargne eOut = new CompteEpargne();
                    eOut = new CompteEpargne(id1, solde, numeroCompte, numClient, tauxEpargne);

                    listeId.Add(eOut);


                }

                return listeId;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();

                conn.Dispose(); // Liberer les ressources
            }

            return null;
        }

        /*   public int Retrait(int idClient, double montant) // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.
           {
               try
               {
                   // Tout d'abord on veut qu'il recupere le solde correspondant à l'ID client

                   // Etape 1 Ouverture de la connexion
                   conn = new SqlConnection(connectionString);
                   conn.Open();

                   // Etape 2: Fprmuler la requete SQL
                   String req = "SELECT*FROM compte_epargne where num_client_e=@Id";


                   // Etape 3: Preparer le bus
                   SqlCommand commande = new SqlCommand(req, conn);

                   // Etape 4: Assigner les parametres et envoyer la requete pour recuperer le resultat
                   commande.Parameters.Add(new SqlParameter("Id", idClient));
                   SqlDataReader rd = commande.ExecuteReader();

                   rd.Read(); // Vu que c'est une seule ligne ici à lire, par besoin du while

                   double solde1 = rd.GetDouble(1);
                   int id1 = rd.GetInt32(4);

                   // instancier un client avec ces valeurs
                   CompteEpargne ceOut = new CompteEpargne(solde1, id1);

                   // Etape 5: J'applique la méthode retrait cc de ce client. Avec cette méthode, il y'aura une baisse de solde du compte.
                   bool resultRetrait = ceOut.Retrait(montant);
                   // Après le retrait, le solde sera donc modifié. On fera une nouvelle requête update pour modifier dans la table.
                   // Par contre le solde est modifié si la condition est remplie. D'où la méthode bool (true or false)

                   if (resultRetrait)
                   {
                       //Etape 6: Ecrire la nouvelle requete SQL pour modifier le solde dans la base SQL
                       String req2 = "update compte_epargne set solde_e=@solde2 where num_client_e_e=@Id2";

                       //Etape 7: preparer le bus
                       SqlCommand commande2 = new SqlCommand(req2, conn);

                       // Etape 8: Assigner les parametres et envoyer la requête
                       commande2.Parameters.Add(new SqlParameter("solde2", ceOut.Solde));
                       commande2.Parameters.Add(new SqlParameter("Id2", ceOut.NumClient));

                       int lignesModifiées = commande2.ExecuteNonQuery();

                       return lignesModifiées;

                   }
                   else
                   {
                       return 0;
                   }
               }
               catch (Exception ex)
               {
                   Console.WriteLine(ex.Message);
                   // e.printStackTrace();
               }
               finally
               {
                   conn.Close();
                   conn.Dispose();
               }
               return 0;
           } */

        public int UpdateCompteEpargneDal(CompteEpargne cli)
        {
            try
            {


                // Ouverture de la connexion
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Faire la requete
                string req = "update compte_epargne set solde_e=@solde, numero_e=@numero, tauxEpargne_e=@tauxEpargne where num_client_e=@id";

                // Preparer le bus pour envoyer la requête
                SqlCommand commande = new SqlCommand(req, conn);

                // Assigner les valeurs
                commande.Parameters.Add(new SqlParameter("solde", cli.Solde));
                commande.Parameters.Add(new SqlParameter("numero", cli.NumeroCompte));
                commande.Parameters.Add(new SqlParameter("tauxEpargne", cli.TauxEpargne));
                commande.Parameters.Add(new SqlParameter("id", cli.NumClient));


                // Envoyer la requete
                int lignesModifiées = commande.ExecuteNonQuery();

                return lignesModifiées;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                conn.Close();

                conn.Dispose(); // Liberer les ressources
            }

            return 0;
        }

        /*    public int Virement(int idClient, double montant, CompteEpargne ce2) // Impossible de realiser ici, car lorsque le SQL reader est en execution, il faut d'abord close la connexion avec d'executer un autre query. Je dois contourner dans Service.
            {
                try
                {
                    // Tout d'abord on veut qu'il recupere le solde correspondant à l'ID client

                    // Etape 1 Ouverture de la connexion
                    conn = new SqlConnection(connectionString);
                    conn.Open();

                    // Etape 2: Fprmuler la requete SQL
                    String req = "SELECT*FROM compte_epargne where num_client_e=@Id";


                    // Etape 3: Preparer le bus
                    SqlCommand commande = new SqlCommand(req, conn);

                    // Etape 4: Assigner les parametres et envoyer la requete pour recuperer le resultat
                    commande.Parameters.Add(new SqlParameter("Id", idClient));
                    SqlDataReader rd = commande.ExecuteReader();

                    rd.Read(); // Vu que c'est une seule ligne ici à lire, par besoin du while

                    double solde1 = rd.GetDouble(1);
                    int id1 = rd.GetInt32(4);

                    // instancier un client avec ces valeurs
                    CompteEpargne ceOut = new CompteEpargne(solde1, id1);

                    // Etape 5: J'applique la méthode retrait cc de ce client. Avec cette méthode, il y'aura une baisse de solde du compte.
                    bool resultVirement = ceOut.Virement(montant, ce2);

                    // Après le virement, le solde sera donc modifié. On fera une nouvelle requête update pour modifier dans la table.
                    // Par contre le solde est modifié si la condition est remplie. D'où la méthode bool (true or false)

                    if (resultVirement)
                    {
                        //Etape 6: Ecrire la nouvelle requete SQL pour modifier le solde dans la base SQL
                        String req2 = "update compte_epargne set solde_e=@solde2 where num_client_e_e=@Id2";

                        //Etape 7: preparer le bus
                        SqlCommand commande2 = new SqlCommand(req2, conn);

                        // Etape 8: Assigner les parametres et envoyer la requête
                        commande2.Parameters.Add(new SqlParameter("solde2", ceOut.Solde));
                        commande2.Parameters.Add(new SqlParameter("Id2", ceOut.NumClient));

                        int lignesModifiées = commande2.ExecuteNonQuery();

                        return lignesModifiées;

                    }
                    else
                    {
                        return 0;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    // e.printStackTrace();
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
                return 0;
            } */
    }
}
