using Conservatoire_musique0.Controleur;
using Conservatoire_musique0.Modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conservatoire_musique0.Vue
{
    public partial class Vue_paiement : Form
    {
        Admin Admin;

        List<Eleve> ListEleve = new List<Eleve>();
        List<Trimestre> LesTrimestres = new List<Trimestre>();

        public Vue_paiement()
        {
            InitializeComponent();
            Admin = new Admin();
            ListEleve = Admin.chargementElevesBD();
            affiche();

        }

        public void affiche()
        {
            try
            {
                listBox1.DataSource = null;
                listBox1.DataSource = ListEleve;
                listBox1.DisplayMember = "Descripiton";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public void afficheTrim()
        {
            try
            {
                listBox2.DataSource = null;
                listBox2.DataSource = LesTrimestres;
                listBox2.DisplayMember = "Descripiton";

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Eleve eleve = (Eleve)listBox1.SelectedItem;
            int idEleve = eleve.Id;
            LesTrimestres = Admin.chargementTrimestreBD(idEleve);
            afficheTrim();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Eleve eleve = (Eleve)listBox1.SelectedItem;
            int eleveId = eleve.Id;
            Trimestre trim = (Trimestre)listBox2.SelectedItem;
            string libelleTrim = trim.Libelle;
            Admin.paiementTrimestre(eleveId, libelleTrim);
            LesTrimestres = Admin.chargementTrimestreBD(eleveId);
            afficheTrim();



        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

            if ((Trimestre)listBox2.SelectedItem != null)
            {

                Trimestre trim = (Trimestre)listBox2.SelectedItem;
                int payer = trim.Payer;
                if (payer == 0)
                {
                    string paiementDate = trim.DateFin;
                    DateTime dateFinTrimestre = DateTime.ParseExact(paiementDate, "dd/MM/yyyy", new CultureInfo("fr-FR", true));
                    DateTime todayDate = DateTime.Today;
                    if (dateFinTrimestre > todayDate)
                    {
                        button1.Show();
                    }
                    else
                    {
                        button1.Hide();
                    }




                }
                else
                {
                    button1.Hide();

                }
            }
            else
            {
                button1.Hide();

            }
        }

        private void Vue_paiement_Load(object sender, EventArgs e)
        {

        }
    }
}
