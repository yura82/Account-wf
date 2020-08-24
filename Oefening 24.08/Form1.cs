using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening_24._08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public List<Werknemer> lijstWerk = new List<Werknemer>();
        private void Form1_Load(object sender, EventArgs e)
        {
            Werknemer Geert = new Werknemer("Geert");
            lijstWerk.Add(Geert);
            Werknemer Frank = new Werknemer("Frank",2200);
            lijstWerk.Add(Frank);
            Werknemer Sofia = new Werknemer("Sofia",3110.00,landVanHerkomst: "Nederlaand");
            lijstWerk.Add(Sofia);
            Werknemer Daniel = new Werknemer("Daniel",landVanHerkomst: "Nederlaand");
            lijstWerk.Add(Daniel);
            cbWerknemers.Items.Add("Geert");
            cbWerknemers.Items.Add("Frank");
            cbWerknemers.Items.Add("Sofia");
            cbWerknemers.Items.Add("Daniel");



        }
       

        private void cbWernemers_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbLand.Text = (cbWerknemers.SelectedItem as Werknemer).LandVanHerkomst;
            lbName.Text = (cbWerknemers.SelectedItem as Werknemer).Naam;
            lbSalarie.Text = (cbWerknemers.SelectedItem as Werknemer).Salaris.ToString();

        }

       
    }
}
