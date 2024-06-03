using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinale.Models
{
    public class Absence
    {
        public int Id { get; set; }
        public DateTime DateDebut { get; set; }
        public DateTime DateFin { get; set; }
        public string Motif { get; set; }
        public Personnel Personnel { get; set; }
    }
}