using System;
using System.Collections.Generic;
using System.Text;

namespace Exercice_principe_S.Models
{
    internal class RendezVous
    {
        public int Id { get; set; }
        public string Client { get; set; } = string.Empty;
        public string Email { get; set; }= string.Empty;

        public DateTime DateHeure { get; set; }

    }
}
