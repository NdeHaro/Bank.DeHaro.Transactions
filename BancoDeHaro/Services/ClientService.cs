using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions
{
    class ClientService
    {
        /// <summary>
        /// Allows client conectate to BankService and send money vía BankTransactionService.
        /// </summary>
        /// <param name="ClientSender">Who send money</param>
        /// <param name="ClientReceiver">Who receives the money</param>
        /// <param name="quantity">How much is passing</param>
        /// <param name="nServ"> Allows server to pass msgs</param>
        /// <param name="BService">Allows client conectate to BankService and send money.</param>
        public void passMoney(Client ClientSender, Client ClientReceiver, double quantity, NotificationService nServ,
                                BankTransactionService BService)
        {
         
            BService.PassMoney(ClientSender, ClientReceiver, quantity, nServ);
        }
    }
}
