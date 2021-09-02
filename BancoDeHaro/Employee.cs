using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeHaro
{
    class Employee
    {
        public string _Name;
        public Account _Account;
        public int _EmplNum;
        public string _Pass;

        public Employee(String Name, String Pass)
        {
            openAccount();
            _Name = Name;
            _Pass = Pass;    
            _EmplNum = new Random().Next();
        }

        private void openAccount()
        {
            _Account = new Account(0);
        }

    }
}
