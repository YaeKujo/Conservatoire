using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Conservatoire_musique0.Modele;
using Connecte.DAL;
using Mysqlx.Crud;
using Conservatoire_musique0.Vue;
using System.Reflection.Metadata.Ecma335;
using Microsoft.VisualBasic.Logging;
using static Mysqlx.Notice.Warning.Types;
using Microsoft.VisualBasic.Devices;

namespace Connecte.DAL
{
    public class PersonneDAO
    {

        // attributs de connexion statiques
        private static string provider = "localhost";

        private static string dataBase = "conservatoire1";

        private static string uid = "root";

        private static string mdp = "";

        private static ConnexionSql maConnexionSql;

        private static MySqlCommand Ocom;


        //Ajouter personne
        public static int AjouterPersonne(Personne personne)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                // Préparez la requête d'insertion avec des paramètres pour éviter les attaques par injection SQL
                string query = "INSERT INTO personne (nom, prenom, tel, mail, adresse) VALUES (@nom, @prenom, @tel, @mail, @adresse)";
                Ocom = maConnexionSql.reqExec(query);
                Ocom.Parameters.AddWithValue("@nom", personne.Nom);
                Ocom.Parameters.AddWithValue("@prenom", personne.Prenom);
                Ocom.Parameters.AddWithValue("@tel", personne.Adresse);
                Ocom.Parameters.AddWithValue("@mail", personne.Mail);
                Ocom.Parameters.AddWithValue("@adresse", personne.Adresse);

                // Exécutez la requête d'insertion et retournez le nombre de lignes affectées
                int rowsAffected = Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }






        }

        //Ajouter eleve
        public static void AjouterEleve( int id, string nom, string prenom, int tel, string mail, string adresse, int bourse)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                // Préparez la requête d'insertion avec des paramètres pour éviter les attaques par injection SQL
                Ocom = maConnexionSql.reqExec("INSERT INTO personne (ID, nom, prenom, tel, mail, adresse) VALUES (@ID, @nom, @prenom, @tel, @mail, @adresse)");
                Ocom.Parameters.AddWithValue("@ID", id);
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@adresse", adresse);
                Ocom.ExecuteNonQuery();

                Ocom = maConnexionSql.reqExec("INSERT INTO eleve (IDELEVE, BOURSE) VALUES (@IDELEVE, @bourse)");
                Ocom.Parameters.AddWithValue("@IDELEVE", id);
                Ocom.Parameters.AddWithValue("@bourse", bourse);
                Ocom.ExecuteNonQuery();

               

                maConnexionSql.closeConnection();

             
            }
            catch (Exception ex)
            {
                throw (ex);
            }
        }





        //récuperation de la liste des prof

        public static List<Prof> getProf()
        {


            List<Prof> lp = new List<Prof>();

            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'object Command
                Ocom = maConnexionSql.reqExec("SELECT IDPROF, ID, nom, prenom, tel, mail, adresse, instrument, salaire FROM prof JOIN personne ON prof.IDPROF = personne.ID");//SELECT nom, prenom, tel, mail, adresse, instrument, salaire FROM prof JOIN personne ON prof.IDPROF = personne.ID
                // lire les données ligne par ligne avec le reader



                MySqlDataReader reader = Ocom.ExecuteReader();

                Prof e;




                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération des valeurs de colonne avec les méthodes de conversion appropriées
                    int id = reader.GetInt32(0);
                    int idprof = reader.GetInt32(1);
                    string nom = reader.GetString(2);
                    string prenom = reader.GetString(3);
                    string tel = reader.GetString(4);
                    string mail = reader.GetString(5);
                    string adresse = reader.GetString(6);
                    string instrument = reader.GetString(7);
                    double salaire = reader.GetDouble(8);

                    // Instanciation d'un objet Prof
                    e = new Prof(id, nom, prenom, tel, mail, adresse, instrument, salaire);

                    // Ajout de cet objet Prof à la liste
                    lp.Add(e);
                }


                // fermeture du reader
                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                // Envoi de la liste au Manager

                return (lp);


            }

            catch (Exception emp)
            {

                throw (emp);

            }



        }
        public static List<Eleve> getEleve()
        {
            List<Eleve> lesEleves = new List<Eleve>();

            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'object Command
                Ocom = maConnexionSql.reqExec("SELECT ID, nom, prenom, tel, mail, adresse, bourse FROM eleve JOIN personne ON eleve.IDELEVE = personne.ID");

                MySqlDataReader reader = Ocom.ExecuteReader();

                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération des valeurs de colonne avec les méthodes de conversion appropriées
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string tel = reader.GetString(3);
                    string mail = reader.GetString(4);
                    string adresse = reader.GetString(5);
                    decimal bourse = reader.GetDecimal(6);

                    // Instanciation d'un objet Eleve
                    Eleve eleve = new Eleve(id, nom, prenom, tel, mail, adresse, bourse);

                    // Ajout de cet objet Eleve à la liste
                    lesEleves.Add(eleve);
                }

                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                return lesEleves;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool connexion(string login, string password)
        {
            bool connect = false;
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                string query = "SELECT COUNT(*) FROM admin WHERE login = @login AND mdp = @password";
                Ocom = maConnexionSql.reqExec(query);
                Ocom.Parameters.AddWithValue("@login", login);
                Ocom.Parameters.AddWithValue("@password", password);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    if ((Int64)reader.GetValue(0) == 1)
                    {
                        connect = true;
                    }
                }

                reader.Close();
                maConnexionSql.closeConnection();
                return (connect);
            }

            catch (Exception emp)
            {

                throw emp;

            }
        }


        public static List<Trimestre> chargementTrimestreBD()
        {

            List<Trimestre> list = new List<Trimestre>();
            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'object Command
                Ocom = maConnexionSql.reqExec("SELECT * FROM trim ");

                MySqlDataReader reader = Ocom.ExecuteReader();

                Trimestre t;

                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération des valeurs de colonne avec les méthodes de conversion appropriées
                    string libelle = reader.GetString(0);
                    string dateFin = reader.GetString(1);
                   
                    t = new Trimestre(libelle, dateFin);

                    list.Add(t);
                        
                    
                }

                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public static bool verifTrimestre(int idEleve, string libelle)
        {
            bool res = false;


            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT COUNT(*) as nbre FROM payer WHERE IDELEVE = @ideleve AND LIBELLE = @libelle AND PAYE = 1");
                Ocom.Parameters.AddWithValue("@ideleve", idEleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);
                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    

                    Int64 nbResult=(Int64)reader.GetValue(0);

                    if ( nbResult > 0) 
                    { 
                        res = true;
                            
                        }
                    
                }

                reader.Close();
                maConnexionSql.closeConnection();
            }

            catch (Exception emp)
            {

                Console.WriteLine(emp.Message);

            }
            return res;
        }

        public static Trimestre recupDetailPaiement(int idEleve, string libelle)
        {
            Trimestre trim= new Trimestre(0,"","",0);


            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                string query = "SELECT payer.IDELEVE,payer.LIBELLE,payer.DATEPAIEMENT,payer.PAYE FROM payer where IDELEVE = @idEleve AND payer.LIBELLE = @libelle";
                Ocom = maConnexionSql.reqExec(query);
                Ocom.Parameters.AddWithValue("@idEleve",idEleve);
                Ocom.Parameters.AddWithValue("@libelle", libelle);


                maConnexionSql.openConnection();
                MySqlDataReader reader = Ocom.ExecuteReader();


                while (reader.Read())
                {
                    // récupération des valeurs de colonne avec les méthodes de conversion appropriées
                    int idEleveP = (int)reader.GetValue(0);
                    string libelleP = (string)reader.GetValue(1);
                    string datePaiement = (string)reader.GetValue(2);
                    int etatPaiement = (int)reader.GetValue(3);

                    trim= new  Trimestre(idEleveP,libelleP,datePaiement,etatPaiement);


                }

                reader.Close();
                maConnexionSql.closeConnection();

                return trim;
            }

            catch (Exception emp)
            {

                throw emp;

            }



        }

        public static void paiementTrimestre(int eleveId, string libelle)
        {

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // Préparez la requête d'insertion avec des paramètres pour éviter les attaques par injection SQL
                string query = "INSERT INTO payer (IDELEVE, LIBELLE, DATEPAIEMENT, PAYE) VALUES (@idEleve, @libelle, NOW(), 1)";
                Ocom = maConnexionSql.reqExec(query);
                Ocom.Parameters.AddWithValue("@idEleve", eleveId);
                Ocom.Parameters.AddWithValue("@libelle", libelle);
                

                maConnexionSql.openConnection();

                // Exécutez la requête d'insertion et retournez le nombre de lignes affectées
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }
            catch (Exception ex)
            {
                throw ex;
            }



        }

        public static List<Seance> chargementSeanceBD(int idprof)
        {
            List<Seance> seanceList = new List<Seance>();

            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'object Command
                Ocom = maConnexionSql.reqExec("SELECT * FROM seance where IDPROF=" + idprof);

                MySqlDataReader reader = Ocom.ExecuteReader();

                Seance s;

                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération des valeurs de colonne avec les méthodes de conversion appropriées
                    int id = (int)reader.GetValue(0);
                    int numSeance = (int)reader.GetValue(1);
                    string tranche = (string)reader.GetValue(2);
                    string jour = (string)reader.GetValue(3);
                    int niveau = (int)reader.GetValue(4);
                    int capacité = (int)reader.GetValue(5);




                    s = new Seance(id, numSeance, tranche, jour, niveau, capacité);

                    seanceList.Add(s);


                }

                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();

                
            }
            catch (Exception ex)
            {
                throw ex;   
            }
            return seanceList;

        }

        public static List<Eleve> chargementSeanceDeEleveBD( int idSeance)
        {
            List<Eleve> listeEleve=new List<Eleve>();
            try
            {
                // Pour se connecter à la base
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

                // ouverture de la connexion
                maConnexionSql.openConnection();

                // exécution de la requete avec l'object Command
                Ocom = maConnexionSql.reqExec("SELECT eleve.IDELEVE, nom, prenom, tel, mail, adresse, bourse FROM eleve JOIN inscription ON eleve.IDELEVE = inscription.IDELEVE JOIN personne ON eleve.IDELEVE = personne.ID WHERE inscription.NUMSEANCE= " + idSeance);

                MySqlDataReader reader = Ocom.ExecuteReader();

                Eleve e;

                // Tant qu'il existe une ligne dans la table
                while (reader.Read())
                {
                    // récupération des valeurs de colonne avec les méthodes de conversion appropriées
                    int id = reader.GetInt32(0);
                    string nom = reader.GetString(1);
                    string prenom = reader.GetString(2);
                    string tel = reader.GetString(3);
                    string mail = reader.GetString(4);
                    string adresse = reader.GetString(5);
                    decimal bourse = reader.GetDecimal(6);

                    



                    e = new Eleve(id, nom, prenom, tel, mail, adresse,bourse);

                    listeEleve.Add(e);


                }

                reader.Close();

                //fermeture de la connexion
                maConnexionSql.closeConnection();


            }
            catch (Exception ex)
            {
                throw ex;
            }
            return listeEleve;
        }

        public static int recuperationLastId()
        {
            // Pour se connecter à la base
            maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);

            // ouverture de la connexion
            maConnexionSql.openConnection();


            // exécution de la requete avec l'object Command
            Ocom = maConnexionSql.reqExec("SELECT MAX(ID) FROM personne; ");

            MySqlDataReader reader = Ocom.ExecuteReader();
            int lastId=0;

            try
            {
                while (reader.Read())
                {
                    lastId = (int)reader.GetValue(0);

                }

                reader.Close();
                //fermeture de la connexion
                maConnexionSql.closeConnection();

                return lastId;

            }
            catch (Exception ex)
            {
                throw ex;
            }
            


        }



        public static List<Instrument> getInstrument()
        {
            List<Instrument> lesInstrument = new List<Instrument>();

            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("SELECT * FROM instrument");
                MySqlDataReader reader = Ocom.ExecuteReader();

                Instrument i;

                while (reader.Read())
                {
                    string libelle = (string)reader.GetValue(0);

                    i = new Instrument(libelle);
                    lesInstrument.Add(i);
                }
                reader.Close();

                maConnexionSql.closeConnection();

                return (lesInstrument);
            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

        public static void ajoutProf(int id, string nom, string prenom, int tel, string mail, string adresse, string instrument, double salaire)
        {
            try
            {
                maConnexionSql = ConnexionSql.getInstance(provider, dataBase, uid, mdp);
                maConnexionSql.openConnection();

                Ocom = maConnexionSql.reqExec("INSERT INTO personne (ID, nom, prenom, tel, mail, adresse) VALUES (@ID, @nom, @prenom, @tel, @mail, @adresse)");
                Ocom.Parameters.AddWithValue("@ID", id);
                Ocom.Parameters.AddWithValue("@nom", nom);
                Ocom.Parameters.AddWithValue("@prenom", prenom);
                Ocom.Parameters.AddWithValue("@tel", tel);
                Ocom.Parameters.AddWithValue("@mail", mail);
                Ocom.Parameters.AddWithValue("@adresse", adresse);
                Ocom.ExecuteNonQuery();



                Ocom = maConnexionSql.reqExec("INSERT INTO prof (IDPROF, instrument, salaire) VALUES (@IDPROF, @instrument, @salaire)");
                Ocom.Parameters.AddWithValue("@IDPROF", id);
                Ocom.Parameters.AddWithValue("@instrument", instrument);
                Ocom.Parameters.AddWithValue("@salaire", salaire);
                Ocom.ExecuteNonQuery();

                maConnexionSql.closeConnection();

            }

            catch (Exception emp)
            {

                throw (emp);

            }
        }

    }



}
