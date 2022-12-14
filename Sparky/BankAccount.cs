using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparky
{
    public class BankAccount
    {
        public int Balance { get; set; }

        private readonly ILogBook _logBook;

        public BankAccount(ILogBook logBook)
        {
            _logBook = logBook;
            Balance = 0;
        }


        public bool Deposit(int ammount)
        {
            Balance += ammount;
            return true;
        }

        public bool Withdraw(int ammount)
        {
            if (ammount <= Balance)
            {
                Balance -= ammount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public int GetBalance()
        {
            return Balance;
        }
    }
}
