using Conservatoire_musique0.Controleur;
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


namespace Conservatoire_musique0.Vue
{
    public partial class Login : Form
    {
        Admin admin = new Admin();
        public Login()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object ssender, EventArgs e)
        {

            string login = textBox1.Text;
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Veuillez entrer votre login et mot de passe.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            bool connect = admin.Connexion(login, password);

            if (connect == true)
            {
                this.Hide();
                Form1 connexion = new Form1();
                connexion.ShowDialog();
            }
            else
            {
                Console.WriteLine("connexion échoué");
            }
        }

       
    }
}