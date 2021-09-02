using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeHaro
{
    class BankTransaction
    {
        public void PassMoney(Client ClientSender, Client ClientReceiver, float quantity)
        {
            if (ClientSender.Account._Amount >= quantity)
            {
                ClientSender.Account._Amount -= quantity;
                ClientReceiver.Account._Amount += quantity;
            }
            else
            {
                Console.WriteLine(ClientSender.Name + " no tiene suficiente salario en la cuenta");
            }
        }

        public void RegisterUser(String Name, String Pass)
        {
            //New Client
            var Client = new Client(Name, Pass);
        }
    }
}
