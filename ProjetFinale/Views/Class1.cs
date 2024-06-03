using ProjetFinale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetFinale.Views
{
    public class Class1
    {
        public class PersonnelView
        {
            public void AfficherPersonnels(List<Personnel> personnels)
            {
                foreach (var personnel in personnels)
                {
                    Console.WriteLine($"Nom: {personnel.Nom}, Prénom: {personnel.Prenom}");
                }
            }
        }
    }
}