using System;
using System.Collections.Generic;
using System.Text;

namespace DeHaro.Bank.Transactions
{
    class NotificationService
    {
        public String _Message;
        
        public void sendMail(Client client, string Args)
        {
            Console.WriteLine(client._Name + Args);
        }
        public void sendMail(Employee employee, string Args)
        {
            Console.WriteLine(employee._Name + Args);
        }



        public void sendSms(Client client, string Args)
        {
            Console.WriteLine(client._Name + Args);
        }
        public void sendSms(Employee employee, string Args)
        {
            Console.WriteLine(employee._Name + Args);
        }
    }
}
