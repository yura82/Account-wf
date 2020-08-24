using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account_wf
{
    public partial class NewAccountForm : Form
    {
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void NewAccountForm_Load(object sender, EventArgs e)
        {
            List<string> myName = new List<string>();
            cbAccountTipe.Items.Add("CREDIT");
            cbAccountTipe.Items.Add("DEBIT");
            cbAccountTipe.Items.Add("DEPOSITE");

        }

        private void btCreate_Click(object sender, EventArgs e)
        {
            
        }
    }
}
