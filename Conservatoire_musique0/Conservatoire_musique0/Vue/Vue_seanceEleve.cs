using Conservatoire_musique0.Controleur;
using Conservatoire_musique0.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conservatoire_musique0.Vue
{
    public partial class Vue_seanceEleve : Form
    {
        Seance seanceDeEleve;
        List<Eleve> eleveList= new List<Eleve>();
        Seance seanceE;
        private Seance idSeance;

        public Vue_seanceEleve(Seance Eseance)
        {
            InitializeComponent();
            this.seanceDeEleve = Eseance;
            int numSeance = Eseance.NumSeance;
            eleveList= Admin.chargementSeanceDeEleveBD(numSeance);
            affiche();


        }
        public void affiche()
        {
            try
            {
                listBox1.DataSource = null;
                listBox1.DataSource = eleveList;
                listBox1.DisplayMember = "Descripiton";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
