using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_des_Evenements
{   // Creation de la classe programme pour créer des objets et executer le programme
    public class Program
    {
        static void Main(string[] args)
        {

            // Création des catégories de billets
            CategorieBillet categorie1 = new CategorieBillet("Normal", 30.0, 100);
            CategorieBillet categorie2 = new CategorieBillet("VIP", 50.0, 50);
            CategorieBillet categorie3 = new CategorieBillet("Tarif_Etudiant", 20, 15);
            CategorieBillet categorie4 = new CategorieBillet("Premium", 200.0, 20);

            // Création des participants
            Participants participant1 = new Participants("Toubal", "Mustapha", "mustapha@gmail.com", "adulte" ,10);
            Participants participant2 = new Participants("Zerrouki", "Nabil", "nabil.zerrouki@gmail.com", "adolessant", 11);
            Participants participant3 = new Participants("Baihi", "Amine", "amine.baihi@gmail.com", "Jeune adulte", 12);
            Participants participant4 = new Participants("Kader", "yacine", "kader.yacine@gmail.com", "Adulte", 13);
            
            // creation du type Evénement
            TypeEvenement type1 = new TypeEvenement("Concert", 1);
            TypeEvenement type2 = new TypeEvenement("Spectacle", 2);
            

            // Création d'une liste pour stocker les catégories de billets
            List<CategorieBillet> categoriesEvenement = new List<CategorieBillet> { categorie1, categorie2, categorie3 };
            List<CategorieBillet> categoriesEvenement2 = new List<CategorieBillet> { categorie4};

            // creation de deux Evénements
            Evenement evenement1 = new Evenement("Concert de Taylor Swift", "Salle de concert Zebra", new DateTime(2024, 4, 10), categoriesEvenement, type1 );
            Evenement evenement2 = new Evenement("Spectacle de magie ", "Salle Principale", new DateTime(2024, 4, 9), categoriesEvenement2, type2);
           
            //affichage des événements crées
            evenement1.AfficherEvenement();
            
            Console.WriteLine();
            evenement2.AfficherEvenement();


            // Création des gestionnaires d'inscription
            GestionnaireInscription gestionnaireInscription = new GestionnaireInscription();
            GestionnaireInscription gestionnaireInscription2 = new GestionnaireInscription();



            Console.WriteLine();

            //verification de la disponibilité des billets
            gestionnaireInscription.VerifierDisponibiliteBillets(evenement1, categorie1);
            categorie1.AfficherQuantiteBilletsRestants();
            
            Console.WriteLine();


            // Inscription des participants aux événements
            gestionnaireInscription.SInscrireAEvenement(evenement1, participant1, categorie1);
            Console.WriteLine();
            gestionnaireInscription.SInscrireAEvenement(evenement1, participant2, categorie2);
            Console.WriteLine();
            gestionnaireInscription.SInscrireAEvenement(evenement1, participant3, categorie3);
            Console.WriteLine();
            gestionnaireInscription2.SInscrireAEvenement(evenement2, participant4, categorie4);
            Console.WriteLine();


            // Annulation de l'inscription d'un participant
           gestionnaireInscription.AnnulerInscription(evenement1, participant1, categorie1);
            


            // Affichage de la liste des participants inscrits à l'événement

            Console.WriteLine($"\nParticipants inscrits à  {evenement1.Nom}:");
            foreach (Participants participant in gestionnaireInscription.Participants)
            {
                Console.WriteLine("- " + participant.Prenom + " " +participant.Nom + "| " + participant.CategorieAge + "| "  );
            }
            Console.WriteLine($"\nParticipants inscrits à  {evenement2.Nom}:");
            foreach (Participants participant in gestionnaireInscription2.Participants)
            {
                Console.WriteLine("- " + participant.Prenom +  " "+ participant.Nom + "| " + participant.CategorieAge + "| ");
            }

          

        }
    }
}
