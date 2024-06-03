using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinale.Models
{
    public class Personnel
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public string Tel { get; set; }
        public string Mail { get; set; }
        public string ServiceAffectation { get; set; }
    }
}