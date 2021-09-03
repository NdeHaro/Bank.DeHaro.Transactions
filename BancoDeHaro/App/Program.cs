using DeHaro.Bank.Transactions.Interface;
using DeHaro.Bank.Transactions.Services;
using System;

namespace DeHaro.Bank.Transactions
{
    class Program
    {
        static void Main(string[] args)
        {
            var BService = new BankTransactionService();
            ISendable NService;
            var CService = new ClientService();
            var EService = new EmployeeService();

            NService = new EmailService();
            var Client1 = BService.RegisterUser("Nachi", "1234", NService);
            var Client2 = BService.RegisterUser("Raul", "4321", NService);
            var Employee = BService.RegisterEmployee("Edu", "1221", NService);

            // Adding money to clients
            BService.AddMoney(Client1, 10000);
            BService.AddMoney(Client2, 4230.23);

            // How much have to pay mensually the clients.
            double tax1, tax2;

            EService.CalculateTaxes(Client1, BService);
            EService.CalculateTaxes(Client2, BService);

            Console.WriteLine(Client1._Name + " have to pay " + Client1._Account._Taxes + "$ mensually.");
            Console.WriteLine(Client2._Name + " have to pay " + Client2._Account._Taxes + "$ mensually.");

            //Client1 send money to client2
            NService = new SmsService();
            CService.passMoney(Client1, Client2, 1250, NService, BService);


            Console.WriteLine("NEW AMOUNT: " + Client1._Name + " has " + Client1._Account._Amount + "$");
            Console.WriteLine("NEW AMOUNT: " + Client2._Name + " has " + Client2._Account._Amount + "$");
        }
    }
}
