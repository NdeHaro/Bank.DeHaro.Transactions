using DeHaro.Bank.Transactions.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions.Services
{
    public class EmailService : ISendable
    {
        public void Send(Client Client, string Args)
        {
            Console.WriteLine(Client._Name + Args);
        }
        public void Send(Employee Employee, string Args)
        {
            Console.WriteLine(Employee._Name + Args);
        }

    }
}
