using Service.Services;
using Service.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service
{
    public class AccountController
    {
        public void Login()
        {
            Console.WriteLine("Add email:");
            string email = Console.ReadLine();

            Console.WriteLine("Add password:");
            string password = Console.ReadLine();

            int role = 1;

            IAccountService account = new AccountService();

            Console.WriteLine(account.Login(email, password, role));
        }
    }
}
