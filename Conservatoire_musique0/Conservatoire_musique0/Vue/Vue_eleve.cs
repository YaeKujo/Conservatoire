using System;
using System.Windows.Forms;
using Connecte.DAL;
using Conservatoire_musique0.Controleur;
using Conservatoire_musique0.Modele;

namespace Conservatoire_musique0.Vue
{
    public partial class Vue_eleve : Form
    {
        int id;
        public Vue_eleve()
        {
            InitializeComponent();
            id = PersonneDAO.recuperationLastId() + 1;


        }


        private void button2_Click(object sender, EventArgs e)
        {
            // Récupérer les valeurs des TextBox
            string nom = textBox1.Text;
            string prenom = textBox4.Text;
            int tel = Convert.ToInt32(textBox3.Text);
            string mail = textBox2.Text;
            string adresse = textBox5.Text;
            int bourse = Convert.ToInt32(textBox6.Text);
            Admin.AjouterEleve(id, nom, prenom, tel, mail, adresse, bourse);

            MessageBox.Show("L'élève a bien été rajouté.");
            this.Close();
            Form1 form1 = new Form1();
            form1.ShowDialog();



        }
    }
}
