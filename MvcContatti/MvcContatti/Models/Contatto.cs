using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcContatti.Models
{
    public class Contatto
    {
        public string Id { get; set; }
        
        public string Nome { get; set; }

        public string Cognome { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }

        public string Indirizzo { get; set; }

    }
}