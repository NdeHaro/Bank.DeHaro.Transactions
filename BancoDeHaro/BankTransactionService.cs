using System;
using System.Collections.Generic;
using System.Text;

namespace BancoDeHaro
{
    class BankTransactionService
    {
        // Prob. is better to declare NotificationService HERE.
        public void PassMoney(Client ClientSender, Client ClientReceiver, double quantity, NotificationService nServ)
        {
            if (ClientSender._Account._Amount >= quantity)
            {
                ClientSender._Account._Amount -= quantity;
                ClientReceiver._Account._Amount += quantity;
                // Bank send the message
                nServ.sendSms(ClientReceiver, ", " + ClientSender._Name + " sent you " + quantity + "$");
                nServ.sendSms(ClientSender, ", you sent " + quantity + "$ to " + ClientReceiver._Name);
            }
            else
            {
                Console.WriteLine(ClientSender._Name + " no tiene suficiente salario en la cuenta");
            }
        }

        public Client RegisterUser(String Name, String Pass, NotificationService nServ)
        {
            //New Client
            var Client = new Client(Name, Pass);
            // Bank send the message
            nServ.sendSms(Client, ", you created an account of client.");
            return Client;
        }

        public Employee RegisterEmployee(String Name, String Pass, NotificationService nServ)
        {
            //New Client
            var Employee = new Employee(Name, Pass);
            // Bank send the message
            nServ.sendSms(Employee, ", you created an account of employee.");
            return Employee;
        }

        public void CalculateTaxes(Client client)
        {
            double tax = 100;

            int amount = (int) client._Account._Amount / 10;

            double FinalAmount = amount * 0.01;

            tax -= FinalAmount;
            if (tax > 0)
            {
                client._Account._Taxes = tax;
            }
            else
            {
                client._Account._Taxes = 0;
            }

        }

        public void AddMoney(Client Client, double Amount)
        {
            Client._Account._Amount += Amount;
        }

        public void TakeMoney(Client Client, double Amount)
        {
            if (Client._Account._Amount > Amount)
            {
                Client._Account._Amount -= Amount;
            }
            else
            {
                double debt = Client._Account._Amount -= Amount;
                Client._Account._Amount = 0;
                Client._Account._Debt = debt * -1;
            }
          
        }
    }
}
