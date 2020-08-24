using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Account_wf
{
   public class YourAccount
    {
        public string AccountNumber;
        public string Name;
        public string LastNAme;
        public double Balance;
        public string TipeOffAccount;

        public YourAccount(string accountNumber, double balance)
        {
            AccountNumber = accountNumber;
            Balance = balance;
        }
    }
}
