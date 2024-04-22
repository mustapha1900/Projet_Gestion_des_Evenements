using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_Gestion_des_Evenements
{           
    // creation de classe Gestionnaire des Inscriptions
    public class GestionnaireInscription
    {    
        //attributs
        private List<CategorieBillet> billetsDisponible = new List<CategorieBillet>();
        private List<Participants> participants = new List<Participants>();
        private List<Evenement> evenements = new List<Evenement>();
        
        // constructeur
        public GestionnaireInscription(List<CategorieBillet> billetsDisponible, List<Participants> participants, List<Evenement> evenements)
        {
            this.billetsDisponible = billetsDisponible;
            this.participants = participants;
            this.evenements = evenements;
        }
        public GestionnaireInscription() { }
        
        // Getters and Setters
        public List<CategorieBillet> BilletsDisponible
        {
            get { return billetsDisponible; }
            set { billetsDisponible = value; }
        }
        public List<Participants> Participants
        {
            get { return participants; }
            set { participants = value; }
        }

        public List<Evenement> Evenements
        {

            get { return evenements; }
            set { evenements = value; }
        }
        // methode pour s'inscrire a l'evenement
        public void SInscrireAEvenement(Evenement evenement, Participants participants, CategorieBillet categorie)
        {
            Console.WriteLine($"Inscription de {participants.Nom} {participants.Prenom} à l'événement {evenement.Nom} dans la catégorie {categorie.Nom}");
            if (categorie.BilletsDisponibles())
            {

                categorie.QuantiteDisponible--;

                Participants.Add(participants);


                Console.WriteLine($"Quantité de billets restants pour la catégorie {categorie.Nom}: {categorie.QuantiteDisponible}");
            }
            else
            {
                Console.WriteLine($"Aucun billet disponible dans la catégorie {categorie.Nom}.");
            }
        }
        // Methode pour annuler une inscription
        public void AnnulerInscription(Evenement evenement, Participants participant, CategorieBillet categorie)
        {
            Console.WriteLine($"Annulation de l'inscription de {participant.Nom} {participant.Prenom} à l'événement {evenement.Nom}");
           
            categorie.QuantiteDisponible++;
            
            Participants.Remove(participant);
            Console.WriteLine($"Participant {participant.Nom} {participant.Prenom} supprimé avec succès.");

            Console.WriteLine($"Quantité de billets restants pour la catégorie {categorie.Nom}: {categorie.QuantiteDisponible}");
        }
        // methode pour verifier la dispoinibilte des billets
        public int VerifierDisponibiliteBillets(Evenement evenement, CategorieBillet categorie)
        {
            Console.WriteLine($"Vérification de la disponibilité des billets pour l'événement {evenement.Nom} dans la catégorie {categorie.Nom}");

            int billetsDisponibles = categorie.QuantiteDisponible;
            
            Console.WriteLine($"Quantité de billets disponibles pour la catégorie {categorie.Nom}: {billetsDisponibles}");

            return billetsDisponibles;
        }

        //Méthode pour ajouter un nouveau participant à la liste des participants inscrits
        public void AjouterParticipant(Participants participant)
        {
            Console.WriteLine("participant inscrit" + participant);
            Participants.Add(participant);
        }



    }
}
