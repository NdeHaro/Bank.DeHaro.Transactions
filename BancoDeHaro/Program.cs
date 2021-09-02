using System;

namespace BancoDeHaro
{
    class Program
    {
        static void Main(string[] args)
        {
            var BService = new BankTransactionService();
            var NService = new NotificationService();
            var CService = new ClientService();
            var EService = new EmployeeService();

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
            CService.passMoney(Client1, Client2, 1250, NService, BService);
        }
    }
}
