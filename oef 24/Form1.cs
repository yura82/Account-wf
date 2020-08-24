using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef_24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Werknemer> allworkers = new List<Werknemer>();
       
        


        private void Form1_Load(object sender, EventArgs e)
        {

            
            Werknemer Geert = new Werknemer("Geert");
            allworkers.Add(Geert);
            Werknemer Daniel = new Werknemer("Daniel",land: "Nederlaand") ;
            allworkers.Add(Daniel);
            Werknemer Sofie = new Werknemer("Sofie",salarie: 3300,land: "Nederland");
            allworkers.Add(Sofie);
            Werknemer Frank  = new Werknemer("Frank",salarie:2200);
            allworkers.Add(Frank);
            
            Werknemerlijst();

        }
        private void Werknemerlijst()
        {
            lbxWorkers.DataSource = null;
            lbxWorkers.DataSource = allworkers;

        }

        private void lbxWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lbName.Text = (lbxWorkers.SelectedItem as Werknemer).Name ;
            lbLand.Text = (lbxWorkers.SelectedItem as Werknemer).Land ;
            lbSalarie.Text = (lbxWorkers.SelectedItem as Werknemer).Salarie.ToString();

        }

       
    }
}
