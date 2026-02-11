using Exercice_principe_S.Models;
using Exercice_principe_S.Persistance;
using Exercice_principe_S.Rappel;
using Exercice_principe_S.Validation;



namespace Exercice_principe_S.Services
{
    internal class ServiceRDV
    {
        private readonly ValidateurRDV _validateur;
        private readonly DepotRDVFichier _depot;
        private readonly RappelConsole _rappel;

        public ServiceRDV (ValidateurRDV validateur, DepotRDVFichier depot, RappelConsole rappel)
        {
            _depot = depot;
            _validateur = validateur;
            _rappel = rappel;
        }

        public void Enregistrer(RendezVous rendezVous)
        {
            _validateur.Valider(rendezVous);
            _depot.Sauvegarder(rendezVous);
            _rappel.EnvoyerRappel(rendezVous);
        }
    }
}
