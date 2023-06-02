using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Connecte.DAL;
using Conservatoire_musique0.Modele;

namespace Conservatoire_musique0.Controleur
{
    internal class Admin
    {
        PersonneDAO personneDAO = new PersonneDAO();

        // Liste des personnes qu'on va utiliser dans toutes les méthodes
        List<Prof> ListeProf;

        // Liste des élèves qu'on va utiliser dans toutes les méthodes
        List<Eleve> lesEleves;

        public Admin()
        {
            // Instanciation de la liste des personnes
            ListeProf = new List<Prof>();
            lesEleves = new List<Eleve>();
        }

        // Récupération de la liste des profs à partir de la DAL
        public List<Prof> chargementPsnBD()
        {
            // Appel de la méthode statique getProf de la classe PersonneDAO
            ListeProf = PersonneDAO.getProf();

            return ListeProf;
        }

        // Récupération de la liste des élèves à partir de la DAL
        public List<Eleve> chargementElevesBD()
        {
            // Appel de la méthode statique getEleve de la classe PersonneDAO
            lesEleves = PersonneDAO.getEleve();

            return lesEleves;
        }

        public bool Connexion(string login, string password)
        {
            bool connecter = PersonneDAO.connexion(login, password);
            return connecter;
        }

        public List<Trimestre> chargementTrimestreBD(int idEleve)
        {
            List<Trimestre> listeTrimestre = PersonneDAO.chargementTrimestreBD();
            List<Trimestre> listeEleve = new List<Trimestre>();

            foreach (Trimestre unTrimestre in listeTrimestre)
            {
                string libelle = unTrimestre.Libelle;
                bool verif = PersonneDAO.verifTrimestre(idEleve, libelle);
                if (verif == true)
                {
                    Trimestre trimPayé = PersonneDAO.recupDetailPaiement(idEleve, libelle);
                    listeEleve.Add(trimPayé);
                }
                else
                {
                    listeEleve.Add(unTrimestre);
                }
            }

            return listeEleve;
        }

        public static void paiementTrimestre(int eleveId, string libelle)
        {
            PersonneDAO.paiementTrimestre(eleveId, libelle);
        }

        public static void AjouterEleve(int id, string nom, string prenom, int tel, string mail, string adresse, int bourse)
        {
            PersonneDAO.AjouterEleve(id, nom, prenom, tel, mail, adresse, bourse);
        }
        public int AjouterPersonne(Personne nouvellePersonne)
        {
            return PersonneDAO.AjouterPersonne(nouvellePersonne);
        }




        public static List<Seance> chargementSeanceBD(int idprof)
        {
            List<Seance> listeSeance = PersonneDAO.chargementSeanceBD(idprof);
            return listeSeance;
        }

        public static List<Eleve> chargementSeanceDeEleveBD(int idSeance)
        {
            List<Eleve> listeEleve = PersonneDAO.chargementSeanceDeEleveBD(idSeance);
            return listeEleve;
        }


        public static void ajoutProf(int id, string nom, string prenom, int tel, string mail, string adresse, string instrument, double salaire)
        {
            PersonneDAO.ajoutProf(id, nom, prenom, tel, mail, adresse, instrument, salaire);
        }

        public static List<Modele.Instrument> chargementInstrument()
        {

            List<Modele.Instrument> maListeInstrument = PersonneDAO.getInstrument();

            return maListeInstrument;
        }


    }
}
