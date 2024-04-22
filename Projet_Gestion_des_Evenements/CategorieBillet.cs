using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_des_Evenements
{
    // creation de la classe categorie de billets
    public class CategorieBillet
    {
        // Attributs
        public string nom;
        public double prix;
        public int quantiteDisponible;

        //Constructeur
        public CategorieBillet(string nom, double prix, int quantiteDisponible)
        {
            this.nom = nom;
            this.prix = prix;
            this.quantiteDisponible = quantiteDisponible;
        }
        public CategorieBillet() { }
        
        // Getters and setters
        public string Nom
        {
            get { return nom; }
            set { nom = value; }

        }
        public double Prix
        {
            get { return prix; }
            set { prix = value; }
        }
        public int QuantiteDisponible
        {
            get { return quantiteDisponible; }
            set { quantiteDisponible = value; }
        }

        // Méthode pour vérifier si des billets sont disponibles
        public bool BilletsDisponibles()
        {
            return quantiteDisponible > 0;
        }

        // methode pour afficher les billets restants
        public void AfficherQuantiteBilletsRestants()
        {
            Console.WriteLine($"Quantité de billets restants pour la catégorie {Nom}: {quantiteDisponible}");
        }

    }
}
