using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_24
{
   public class Werknemer
    {
        public string Name;
        public double Salarie;
        public string Land;
        public Werknemer(string name,string land = "Belgie", double salarie = 2440.50)

        {
            Name = name;
            Salarie = salarie;
            Land = land;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
