using Models.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dao_DAL.Dao_DAL_Client 
{
  
    public class DAL_Client : I_DAL_Client
    {
         
      // public ObservableCollection<Client> liste = new ObservableCollection<Client>(); // On crée une liste où notre resultat sera stockée. On peut la mettre ici (linstancier) pour que ça appartienne à toute la classe, où à l'interieur de la boucle getAllClient, vu que ça retourne cette liste.
        // Definir la chaine de connection qui contient les infos de la bd
        // cad nom du serveur (.) ; nom de la bdd (db_cour_ado) ; identifiant (sa); mot de passe(Admin@123)
        private string connectionString = "Data Source =.; Initial Catalog =compte_bancaire; User ID=sa; Password=Admin@123";  // Pour lui dire en local, on met le point pour eviter d'écrire tout le nom du serveur (LAPTOP-FMI...)

        // Declaration d'un champs pour la connection
        private SqlConnection conn = null; // type SqlConnection pour la connection

        public int AddClientDal(Client cli)
        {
            try
            {
                // Ouvrir la connexion
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Formuler la requete
                string req = "insert into clients (nom_e, prenom_e, adresse_e, codePostal_e, ville_e, telephone_e) values (@nom, @prenom, @adresse, @codePostal, @ville, @telephone)";

                // prepare le bus pour envoyer la requete et la connexion VERS SQL à traver le bus
                SqlCommand commande = new SqlCommand(req, conn);

                // Assignation des parametres
                commande.Parameters.Add(new SqlParameter("nom", cli.Nom));
                commande.Parameters.Add(new SqlParameter("prenom", cli.Prenom));
                commande.Parameters.Add(new SqlParameter("adresse", cli.Adresse));
                commande.Parameters.Add(new SqlParameter("codePostal", cli.CodePostal));
                commande.Parameters.Add(new SqlParameter("ville", cli.Ville));
                commande.Parameters.Add(new SqlParameter("telephone", cli.Telephone));
                

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

        public int DeleteClientDal(int id)
        {
            try
            {
                // Ouverture de la connexion
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Faire la requete
                string req = "delete from clients where idClient_e = @Id";

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

        public ObservableCollection<Client> GetAllClientDal()
          //  public List<Client> GetAllClientDal()
        {
            try // Le try est le programme a executer normalement. Et s'il n'est pas executé, il va reoturner sur null tout à la fin de la boucle
            {

                // Etape 1: Ouverture de la connexion (Instancier un objet de type sqlConnection et lui specifier la chaine de connection)
                conn = new SqlConnection(connectionString); // ou SqlConnection conn = new SqlConnection(connectionString); Mais conn est déjà declaré plus haut

                // Etape 2: Ouverture de la connexion
                conn.Open();

                // Etape3: Ecrire la requête SQL
                string req = "select * from clients";

                // Etape 4: Preparer le bus qui va Recuperer la requete SQL vers c#. C'est le bus qui va transporter la requête. le bus commande est de type SqlCommand)
                SqlCommand commande = new SqlCommand(req, conn); // bus

                // Etape 5 Executer la requête SQL et recuperer le résultat (appel d'une des méthodes de l'objet SqlCommand)
                SqlDataReader rd = commande.ExecuteReader();     // ExecureNonQuery pour les commandes qui ne retournent pas de resultat 'insert, update, delete)
                                                                 // SqlDataReader
               // List<Client> liste = new List<Client>();
               ObservableCollection<Client> liste = new ObservableCollection<Client>();


                while (rd.Read()) // Parcourir l'objet SQLDatareader en utilisant sa méthode Read() pour deplacer le curseur à chaque itteration
                {
                    int id1 = rd.GetInt32(0); // Lorsqu'on recupere rd["ID"], il recupere en type objet, cad type string. Faurt donc le convertir
                    string nom = rd.GetString(1); // On peut recuperer via le getX . Le X ici est le type de la colonne et a utilise un indexeur de colonne. l'indexeur 1 correspond à la colonne Nom
                    string prenom = rd.GetString(2);
                    string adresse = rd.GetString(3);
                    int codePostal = rd.GetInt32(4);
                    string ville = rd.GetString(5);
                    string telephone = rd.GetString(6);

                    // Instancier un etudiant avec ces valeurs
                    Client cliOut = new Client(id1, nom, prenom, adresse, codePostal, ville, telephone);

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

        public ObservableCollection<Client> GetClientByIdDal(int id)
        {
            try
            {
                // Ouverture de la connection
                conn = new SqlConnection(connectionString);
                conn.Open();

                // formuler la requete à faire
                string req = "select * from clients where idClient_e = @Id";

                // Preparer le bus qui va envoyer la requete
                SqlCommand commande = new SqlCommand(req, conn); // Commande ici remplace le ps

                // Assignation des valeurs aux paramètres de la requète sql
                // ps.setInt(1, id);

                commande.Parameters.Add(new SqlParameter("Id", id));

                // string commande.Parameters.Add("id_e", SqlDbType.VarChar, 80).Value = "toasters";

                // Envoyer la requete vers sql
                SqlDataReader rd = commande.ExecuteReader(); // Commande ici remplace le ps
                
                ObservableCollection<Client> liste = new ObservableCollection<Client>();
                Client eOut = new Client();

                while (rd.Read()) // Parcourir la table sql et recuperer les informations
                {
                    int id1 = rd.GetInt32(0); // Lorsqu'on recupere rd["ID"], il recupere en type objet, cad type string. Faurt donc le convertir
                    string nom = rd.GetString(1); // On peut recuperer via le getX . Le X ici est le type de la colonne et a utilise un indexeur de colonne. l'indexeur 1 correspond à la colonne Nom
                    string prenom = rd.GetString(2);
                    string adresse = rd.GetString(3);
                    int codePostal = rd.GetInt32(4);
                    string ville = rd.GetString(5);
                    string telephone = rd.GetString(6);

                    eOut = new Client(id1, nom, prenom, adresse, codePostal, ville, telephone);
                    liste.Add(eOut);

                }

                return liste;

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


        public int UpdateClientDal(Client cli)
        {
            try
            {


                // Ouverture de la connexion
                conn = new SqlConnection(connectionString);
                conn.Open();

                // Faire la requete
                string req = "update clients set nom_e=@nom, prenom_e=@prenom, adresse_e=@adresse, codePostal_e=@codePostal, ville_e=@ville, telephone_e=@telephone where idClient_e=@id";

                // Preparer le bus pour envoyer la requête
                SqlCommand commande = new SqlCommand(req, conn);

                // Assigner les valeurs
                commande.Parameters.Add(new SqlParameter("nom", cli.Nom));
                commande.Parameters.Add(new SqlParameter("prenom", cli.Prenom));
                commande.Parameters.Add(new SqlParameter("adresse", cli.Adresse));
                commande.Parameters.Add(new SqlParameter("codePostal", cli.CodePostal));
                commande.Parameters.Add(new SqlParameter("ville", cli.Ville));
                commande.Parameters.Add(new SqlParameter("telephone", cli.Telephone)) ;
                commande.Parameters.Add(new SqlParameter("id", cli.Id));

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
    }
}
