using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions
{
    class BankTransactionService
    {
        // Prob. is better to declare NotificationService HERE.

        /// <summary>
        /// Allows to Clients to tansfer Money
        /// </summary>
        /// <param name="ClientSender">Client who send money</param>
        /// <param name="ClientReceiver">Client who receives money</param>
        /// <param name="quantity">Quantity of money</param>
        /// <param name="nServ">Class to notifications</param>
        public void PassMoney(Client ClientSender, Client ClientReceiver, double quantity, NotificationService nServ)
        {
            if (ClientSender._Account._Amount >= quantity)
            {
                AddMoney(ClientReceiver, quantity);
                TakeMoney(ClientSender, quantity);
                /*ClientSender._Account._Amount -= quantity;
                ClientReceiver._Account._Amount += quantity;*/
                // Bank send the message
                nServ.sendSms(ClientReceiver, ", " + ClientSender._Name + " sent you " + quantity + "$");
                nServ.sendSms(ClientSender, ", you sent " + quantity + "$ to " + ClientReceiver._Name);
            }
            else
            {
                Console.WriteLine(ClientSender._Name + " no tiene suficiente salario en la cuenta");
            }
        }

        /// <summary>
        /// Allows to Register an User and send notification via SMS
        /// </summary>
        /// <param name="Name">Name of User</param>
        /// <param name="Pass">Pass of User</param>
        /// <param name="nServ">Class to notifications</param>
        /// <returns>Client created</returns>
        public Client RegisterUser(String Name, String Pass, NotificationService nServ)
        {
            //New Client
            var Client = new Client(Name, Pass);
            // Bank send the message
            nServ.sendSms(Client, ", you created an account of client.");
            return Client;
        }

        /// <summary>
        /// Allows to Register an Employee and send notification via SMS
        /// </summary>
        /// <param name="Name">Name of Employee</param>
        /// <param name="Pass">Pass of User</param>
        /// <param name="nServ">Class to notifications</param>
        /// <returns>Employee created</returns>
        public Employee RegisterEmployee(String Name, String Pass, NotificationService nServ)
        {
            //New Client
            var Employee = new Employee(Name, Pass);
            // Bank send the message
            nServ.sendSms(Employee, ", you created an account of employee.");
            return Employee;
        }


        /// <summary>
        /// Allows Employee to calculate taxes mensually
        /// </summary>
        /// <param name="client">Client to calculate</param>
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
        
        /// <summary>
        /// Add money to an Account
        /// </summary>
        /// <param name="Client">Client to add money</param>
        /// <param name="Amount">Amount of money</param>
        public void AddMoney(Client Client, double Amount)
        {
            Client._Account._Amount += Amount;
        }

        /// <summary>
        /// Take money from an Account
        /// </summary>
        /// <param name="Client">Client to add money</param>
        /// <param name="Amount">Amount of money</param>
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
