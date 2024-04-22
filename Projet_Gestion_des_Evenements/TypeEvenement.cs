using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_des_Evenements
{
     // creation de la classe TypeEvennement
    public class TypeEvenement
    {    
        //Attributs
        private string nom;
        private int id;

        // constructeur
        public TypeEvenement(string nom, int id)
        {
            this.nom = nom;
            this.id = id;

        }
        // Getters and setters
        public string Nom
        {
            get { return nom; } 
            set {  nom = value; }
        }
        public int ID 
        {
            get { return id; }
            set { id = value; }
        }
        
       
    }
}
