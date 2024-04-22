using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_des_Evenements
{
       // creation de la classe participants
    public class Participants
    {
         // Attributs
        private int idParticipant;
        private string nom;
        private string prenom;
        private string email;
        private string categorieAge;

        // constructeur
        public Participants(string nom, string prenom, string email, string categorieAge, int idparticipant)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.email = email;
            this.categorieAge = categorieAge;
            this.idParticipant = idparticipant;
        }
        public Participants() { }

        // getters and setters
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Prenom
        {
            get { return prenom; }
            set { prenom = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string CategorieAge
        {
            get { return categorieAge; }
            set { categorieAge = value; }
        }
        public int IdParticipant
        {
            get { return idParticipant; }
            set { idParticipant = value; }
        }
        

       
    }
}
