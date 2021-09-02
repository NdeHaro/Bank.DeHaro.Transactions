using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions
{
     public class Account
    {
        public double _Amount;
        public double _Debt;
        public int _Number;
        public double _Taxes;

        public Account(float amount)
        {
            _Amount = amount;
            var random = new Random();
            _Number = random.Next();
            _Debt = 0;
            _Taxes = 0;
        }


        
    }
}
