using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Conservatoire_musique0.Modele
{
    public class Eleve : Personne
    {
        protected decimal bourse;

        public Eleve(int id, string nom, string prenom, string tel, string mail, string adresse, decimal bourse)
            : base(id, nom, prenom, tel, mail, adresse)
        {
            this.bourse = bourse;
        }

        public object Bourse { get; internal set; }

        public decimal GetBourse()
        {
            return bourse;
        }

        public void SetBourse(decimal bourse)
        {
            this.bourse = bourse;
        }

        public override string ToString()
        {
            string[] rowData = { id.ToString(), nom, prenom, tel, mail, adresse, bourse.ToString() };
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
