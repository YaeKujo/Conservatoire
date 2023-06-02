using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Conservatoire_musique0.Modele
{
    public class Seance
    {
        private int idProf;
        private int numSeance;
        private string tranche;
        private string jour;
        private int niveau;
        private int capacite;



        public Seance(int idProf, int numSeance, string tranche, string jour, int niveau, int capacite)
        {
            this.idProf = idProf;
            this.numSeance = numSeance;
            this.tranche = tranche;
            this.jour = jour;
            this.niveau = niveau;
            this.capacite = capacite;

        }





        public int IdProf { get => idProf; set => idProf = value; }
        public int NumSeance { get => numSeance; set => numSeance = value; }
        public string Tranche { get => tranche; set => tranche = value; }
        public string Jour { get => jour; set => jour = value; }
        public int Niveau { get => niveau; set => niveau = value; }
        public int Capacite { get => capacite; set => capacite = value; }

        public override string ToString()
        {
            return "-  Tranche: " + tranche + ",  Jour: " + jour + ",  Niveau: " + niveau + ",  Capacite: " + capacite;

        }


    }
}
