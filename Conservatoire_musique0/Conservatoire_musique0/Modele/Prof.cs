using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_musique0.Modele
{
   
    public class Prof
    {
        private int id;
        private string nom;
        private string prenom;
        private string tel;
        private string mail;
        private string adresse;
        private string instru;
        private double salaires;



        public Prof(int id, string nom, string prenom, string tel, string mail, string adresse, string instrument, double salaire)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.adresse = adresse;
            this.instru = instrument;
            this.salaires = salaire;
        }



        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Instru { get => instru; set => instru = value; }
        public double Salaires { get => salaires; set => salaires = value; }

        public override string ToString()
        {
            string[] rowData = { nom, prenom, tel, mail, adresse, instru, salaires.ToString() };
            string[] formattedData = new string[rowData.Length];

            int maxColumnWidth = 20; // Longueur maximale de chaque colonne

            // Formater chaque élément en ajustant sa longueur
            for (int i = 0; i < rowData.Length; i++)
            {
                string data = rowData[i];

                // Tronquer les données si elles dépassent la longueur maximale
                if (data.Length > maxColumnWidth)
                {
                    data = data.Substring(0, maxColumnWidth - 3) + "...";
                }

                int spaceCount = maxColumnWidth - data.Length;

                // Ajouter des espaces supplémentaires pour atteindre la longueur maximale
                formattedData[i] = data + new string(' ', spaceCount);
            }

            string tableRow = string.Join("  ", formattedData); // Utiliser deux espaces comme séparateur entre les colonnes
            return tableRow;
        }






    }
}
