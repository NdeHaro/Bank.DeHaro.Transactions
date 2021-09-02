using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeHaro
{
    public class Client
    {
        public string _Name;
        public Account _Account;
        public string _Pass;

        public Client(String Name, String Pass)
        {
            openAccount();
            _Name = Name;
            _Pass = Pass;
        }

        private void openAccount()
        {
            _Account = new Account(0);
        }

    }
}
