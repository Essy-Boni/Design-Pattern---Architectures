using GestionFacture.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFacture.Services
{
    internal class ServiceFacture
    {
        public void Enregistrer(Facture facture)
        {
            //validation (1ère responsabilité) - si montant invalide on lève l'exception
            if (facture.Montant <= 0)
            {
                throw new ArgumentNullException("Le montant doit être positif.");
            }

            //Calcul de la TVA (2ème responsabilité) - on modifie le montant
            facture.Montant = facture.Montant * 1.20m;

            // Sauvegarder (3ème responsabilité) - on écrit dans un fichier
            string contenu = $"Facture{facture.Id} - Client : {facture.Client} - Montant :{facture.Montant}";
            File.WriteAllText($"facture_{facture.Id}.txt", contenu);

            // Notification (4ème responsabilité) - on affiche un message
            Console.WriteLine($"[Notification pour {facture.Client}] Facture enregistrée avec succès");

            //Problème : 4 responsabilités dans une seule classe. Si on change la TVA, le format du fichier ou le canl de notification (sms par mail par exemple), on modifie la même classe
            // Risque de régression du code.
        }
    }
}
