using System;

namespace BancoDeHaro
{
    class Program
    {
        static void Main(string[] args)
        {
            var BTrans = new BankTransactionService();
            var NService = new NotificationService();

            var Client1 = BTrans.RegisterUser("Nachi", "1234", NService);
            var Client2 = BTrans.RegisterUser("Raul", "4321", NService);
            var Employee = BTrans.RegisterEmployee("Edu", "1221", NService);




        }
    }
}
