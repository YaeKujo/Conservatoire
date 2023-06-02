using Connecte.DAL;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Conservatoire_musique0.Vue
{
    public partial class Vue_prof : Form
    {
        Instrument instrument;
        List<Instrument> lesInstruments = new List<Instrument>();
        int id;
        public Vue_prof()
        {
            InitializeComponent();

            lesInstruments = Admin.chargementInstrument();
            id = PersonneDAO.recuperationLastId() + 1;
            affiche();
        }

        public void affiche()
        {
            try
            {
                Instrument.DataSource = null;
                Instrument.DataSource = lesInstruments;
                Instrument.DisplayMember = "Description";
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }




        private void button2_Click_1(object sender, EventArgs e)
        {
            string nom = textBox1.Text;
            string prenom = textBox4.Text;
             int tel = Convert.ToInt32(textBox3.Text);
             string email = textBox2.Text;
            string adresse = textBox5.Text;
            string instrument = Instrument.Text;
            double salaire = Convert.ToDouble(textBox7.Text);

            Admin.ajoutProf(id, nom, prenom, tel, email, adresse, instrument, salaire);

            MessageBox.Show("Le professeur a bien été ajouté");
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();


        }
    }
    }

