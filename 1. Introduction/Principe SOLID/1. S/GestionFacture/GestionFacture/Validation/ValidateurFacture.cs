using GestionFacture.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionFacture.Validation
{
    internal class ValidateurFacture
    {
        public void Valider(Facture facture)
        {
            if (facture.Montant <= 0)
            {
                throw new ArgumentException("Le montant doit être positif");
            }
        }
    }
}
