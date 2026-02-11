using Exercice_principe_S.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_principe_S.Validation
{
    internal class ValidateurRDV
    {
        public void Valider(RendezVous rendezVous) 
        {
            if (rendezVous.DateHeure <= DateTime.Now)
            {
                throw new ArgumentException("La date du RDV doit être dans le future");
            }
        }
    }
}
