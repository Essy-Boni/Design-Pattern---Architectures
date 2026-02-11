using Exercice_principe_S.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_principe_S.Persistance
{
    internal class DepotRDVFichier
    {
        public void Sauvegarder(RendezVous rendezVous)
        {
            string contenu = $"RDV {rendezVous.Id} - Client: {rendezVous.Client} - Date: {rendezVous.DateHeure}";
            File.WriteAllText($"rendezvous_{rendezVous.Id}.txt", contenu);
        }
    }
}
