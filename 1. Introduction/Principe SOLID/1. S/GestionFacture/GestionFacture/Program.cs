
using GestionFacture.Models;
using GestionFacture.Services;

var service = new ServiceFacture(); //On crée le service (constructeur vide)
var facture = new Facture { Id = 1, Client = "M2i", Montant = 100m }; //Facture test

service.Enregistrer(facture);
Console.WriteLine("Terminé");