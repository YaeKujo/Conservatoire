using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Conservatoire_musique0.Modele;
using Conservatoire_musique0.Controleur;

namespace Conservatoire_musique0.Vue
{
    public partial class Vue_seanceProf : Form
    {
        Vue_seanceProf seanceProf;
        List<Seance> LesSeances = new List<Seance>();
        Prof Prof;
        public Vue_seanceProf( Prof prof)
        {
            InitializeComponent();
            Prof = prof;
            int idprof= prof.Id;
            LesSeances = Admin.chargementSeanceBD(idprof);
           button1.Show();
            affiche();
        }
        public void affiche()
        {
            try
            {
                listBox1.DataSource = null;
                listBox1.DataSource = LesSeances;
                listBox1.DisplayMember = "Descripiton";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Seance seance = (Seance)listBox1.SelectedItem;
            Vue_seanceEleve vue_SeanceEleve = new Vue_seanceEleve(seance);
            vue_SeanceEleve.Show();



        }
    }
}
