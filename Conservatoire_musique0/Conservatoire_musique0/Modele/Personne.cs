using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Conservatoire_musique0.Modele;

public class Personne
{
    protected int id;
    protected string nom;
    protected string prenom;
    protected string tel;
    protected string mail;
    protected string adresse;

    public int Id { get => id; }
    public string Nom
    {
        get => nom;
        set => nom = value;
    }

    public string Prenom
    {
        get => prenom;
        set => prenom = value;
    }

    public string Tel
    {
        get => tel;
        set => tel = value;
    }

    public string Mail
    {
        get => mail;
        set => mail = value;
    }

    public string Adresse
    {
        get => adresse;
        set => adresse = value;
    }

    //Constructeur de la classe Personne
    public Personne(int unId, string unNom, string unPrenom, string unTel, string unMail, string uneAdresse)
    {
        this.id = unId;
        this.nom = unNom;
        this.prenom = unPrenom;
        this.tel = unTel;
        this.mail = unMail;
        this.adresse = uneAdresse;
    }

    // Constructeur vide
    public Personne()
    {

    }

    // pour afficher la liste par la suite
    public override string ToString()
    {
        return "Id : " + this.id + " Nom :" + this.nom + " Prenom : " + this.prenom + " Tel : " + this.tel + " Mail : " + this.mail + " Adresse : " + this.adresse;
    }
}
