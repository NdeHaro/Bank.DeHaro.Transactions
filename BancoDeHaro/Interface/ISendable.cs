using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions.Interface
{
    public interface ISendable
    {
        public void Send(Client Client, string Args);
        public void Send(Employee Employee, string Args);
    }
}
