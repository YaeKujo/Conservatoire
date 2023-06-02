using Conservatoire_musique0.Controleur;
using Conservatoire_musique0.Modele;
using Conservatoire_musique0.Vue;
using System.Windows.Forms;

namespace Conservatoire_musique0
{
    public partial class Form1 : System.Windows.Forms.Form
    {


        Admin unAdmin;

        List<Prof> lprsn = new List<Prof>();
        List<Eleve> eleves = new List<Eleve>();


        public Form1()
        {
            InitializeComponent();

            unAdmin = new Admin();


            lprsn = unAdmin.chargementPsnBD();

            eleves = unAdmin.chargementElevesBD();
            


            // méthode qui affiche les  
            affiche();


        }

        private void affiche()
        {



            try
            {

                // Initialisation de la listbox
                listBoxPrsn.DataSource = null;

                //   lier la listbox avec la collection
                listBoxPrsn.DataSource = lprsn;

                // Affichage des employes en utilisant la Propriété Description de la classe Employe
                listBoxPrsn.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            



            try
            {

                // Initialisation de la listbox
                listBoxEleve.DataSource = null;

                //   lier la listbox avec la collection
                listBoxEleve.DataSource = eleves;

                // Affichage des employes en utilisant la Propriété Description de la classe Employe
                listBoxEleve.DisplayMember = "Description";


            }


            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }






        }

     




        private void Form1_Load(object sender, EventArgs e)
        {
            int x = (this.Width - menuStrip1.Width) / 2;
            menuStrip1.Location = new Point(x, menuStrip1.Location.Y);




          

        }

        private void elevesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vue_eleve formEleve = new Vue_eleve();
            formEleve.Show();

        }

        private void inscriptionProfesseurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Vue_prof formprof = new Vue_prof();
            formprof.Show();

        }

        private void suivisDePaiementÉlèveToolStripMenuItem_Click(object sender, EventArgs e)
        {


            Vue_paiement formpaiement = new Vue_paiement();
            formpaiement.Show();


        }

        private void séanceÉlèveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Prof prof = (Prof)listBoxPrsn.SelectedItem;

            Vue_seanceProf formseanceProf = new Vue_seanceProf(prof);
            formseanceProf.Show();



        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }









        /* private void listBoxPrsn_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (listBox1.Visible)
             {
                 listBox1.Visible = false;
             }
             else
             {
                 listBox1.Visible = true;
             }
         }*/
    }
}