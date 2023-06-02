using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_musique0.Modele
{
    public class Trimestre
    {
        private string libelle;
        private string dateFin;
        private int idEleve;
        private int payer;
        private string datePaiement;

        public Trimestre(string libelle, string dateFin)
        {
            this.libelle = libelle;
            this.dateFin = dateFin; 
           

        }

        public Trimestre(int idEleve, string libelle, string datePaiement, int payer)
        {
            this.idEleve = idEleve;
            this.libelle = libelle;
            this.DatePaiement = datePaiement;
            this.payer = payer;

        }

        public string Libelle { get => libelle; set => libelle = value; }
        public string DateFin { get => dateFin; set => dateFin = value; }
        public int IdEleve { get => idEleve; set => idEleve = value; }
        public string DatePaiement { get => datePaiement; set => datePaiement = value; }
        public int Payer { get => payer; set => payer = value; }


        public override string ToString()
        {
            if (payer == 1)
            {
                return libelle + " a bien été payé le : " + datePaiement;
            }
            else
            {
                return libelle + " à une date de paiement maximale jusqu'au : " + dateFin;
            }


        }


    }
}
