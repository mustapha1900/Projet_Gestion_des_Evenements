using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_des_Evenements
{   
    // creation de la classe evenement
    public class Evenement
    {   
        // Attributs
        private string nom;
        private string lieu;
        private DateTime date;
        private List<CategorieBillet> categoriesBillets;
        private TypeEvenement typeEvenement;
        
        // Constructeur
        public Evenement(string nom, string lieu, DateTime date, List<CategorieBillet> categoriesBillets, TypeEvenement typeEvenement)
        {
            this.nom = nom;
            this.lieu = lieu;
            this.date = date;
            this.categoriesBillets = categoriesBillets;
            this.typeEvenement = typeEvenement;
        }
        // Getters and setters
        public string Nom
        {
            get { return nom; }
            set { nom = value; }
        }
        public string Lieu
        {
            get { return lieu; }
            set { lieu = value; }
        }
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }
        public List<CategorieBillet> CategoriesBillets
        {
            get { return categoriesBillets; }
            set { categoriesBillets = value; }
        }
        public TypeEvenement TypeEvenement
        {
            get { return typeEvenement;}  
            set { typeEvenement = value; }
        }
       
        // Methode pour ajouter une gategorie de billet

        public void AjouterCategorieBillet (CategorieBillet categorie)
        {
            categoriesBillets.Add(categorie);
        }
        // Méthode pour affichager les informations de l'événement
        public void AfficherEvenement()
        {
            Console.WriteLine($"Les information de l'évènement : {Nom} " ); 
            Console.WriteLine($"Nom: {Nom}, Lieu: {Lieu}, Date: {Date.ToShortDateString()}, Type: {TypeEvenement.Nom} ,ID: {TypeEvenement.ID} ");
            Console.WriteLine("Catégories de billets :");
            foreach (var categorie in CategoriesBillets)
            {
                Console.WriteLine($"- {categorie.Nom} : {categorie.QuantiteDisponible} billets disponibles");
            }
        }
    }
}
