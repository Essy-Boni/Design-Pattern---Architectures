using Exercice_principe_S.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_principe_S.Rappel
{
    internal class RappelConsole
    {
        public void EnvoyerRappel(RendezVous rendezVous)
        {
            Console.WriteLine($"[Rappel pour {rendezVous.Client}] Rappel : rendez-vous le {rendezVous.DateHeure}");
        }
    }
}
