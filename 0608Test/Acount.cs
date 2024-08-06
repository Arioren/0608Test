using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0608Test
{
    internal class Account
    {
        private protected int balance;
        public int GetBalance() { return balance; }
    }

    internal class SavingsAccount : Account
    {
        public SavingsAccount()
        {
            balance = 0;
        }
    }
}