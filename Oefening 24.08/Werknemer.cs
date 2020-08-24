using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening_24._08
{
    public class Werknemer
    {
        public string  Naam{ get; set; }
        public double Salaris { get; set; }

        public string LandVanHerkomst { get; set; }

        public Werknemer(string naam, double salaris = 2440.50, string landVanHerkomst = "Belgie")
        {
            Naam = naam;
            Salaris = salaris;
            LandVanHerkomst = landVanHerkomst;
        }
       
    }
}
