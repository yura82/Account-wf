using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef_24
{
    public class Inncome
    {

        public bool Contracttipe { get; set; }
        public double Bruttobedrag { get; set; }
        public double BTWprocent { get; set; }
        public Inncome(double salaris = 2440.50)
        {
            Contracttipe = false;
            Bruttobedrag = salaris;
            BTWprocent = 1.21;


        }
        public double NettCalcul()
        {
            double netrbedrag = Bruttobedrag / BTWprocent;
            return Math.Round(netrbedrag, 2);
        }
        public override string ToString()
        {
            return $"Netto : " + " " + NettCalcul();
        }
        public string MyContractTipe()
        {
            if (Contracttipe)
            {
                return "Maandcontract";
            }
            else return "Weekcontract";
        }
    }
}
