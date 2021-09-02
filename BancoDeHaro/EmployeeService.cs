using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions
{

    class EmployeeService
    {
        /// <summary>
        /// Allows Employee to calculate taxes for client
        /// </summary>
        /// <param name="Client">Client to calculate</param>
        /// <param name="BService">Allows Employee to conect Bank service</param>
        public void CalculateTaxes(Client Client, BankTransactionService BService)
        {
           BService.CalculateTaxes(Client);
        }
        public void passMoney(Client ClientSender, Client ClientReceiver, double quantity, NotificationService nServ,
                                BankTransactionService BService)
        {

            BService.PassMoney(ClientSender, ClientReceiver, quantity, nServ);
        }
    }
}
