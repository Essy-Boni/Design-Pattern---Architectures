using Exercice_principe_S.Models;
using Exercice_principe_S.Persistance;
using Exercice_principe_S.Rappel;
using Exercice_principe_S.Services;
using Exercice_principe_S.Validation;


var validateur = new ValidateurRDV();
var depot = new DepotRDVFichier();
var rappel = new RappelConsole();
var service = new ServiceRDV(validateur, depot, rappel);

var rdv = new RendezVous { Id = 1, Client = "dupont", DateHeure = DateTime.Now.AddDays(1) };

service.Enregistrer(rdv);
Console.WriteLine($"Terminé. Vérifiez le fichier rendezvous_{rdv.Id}.txt");