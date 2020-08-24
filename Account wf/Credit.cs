using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_wf
{
     class Credit: YourAccount
    {
        public int CVCnumber;

        public Credit(string accountnumber, double balance ) : base(accountnumber,balance)

        {
            CVCnumber = GenerateCVC();
            TipeOffAccount = "Credit Recening";
        }
        public int GenerateCVC()
        {
            int cvc = 0;
            Random rnd = new Random();
            cvc = Convert.ToInt32(cvc.ToString() + rnd.Next(0, 9).ToString());
            return cvc;
        }
    }
}
