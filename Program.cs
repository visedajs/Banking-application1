using System;
using System.Collections.Generic;

namespace BankingApp_202101
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Datorium Digital Bank***");

            List<BankAccount> accounts = new List<BankAccount>();

            accounts.Add(new BankAccount("DDB123456789", "Linus Torvalds", 4000000, "EUR"));
            accounts.Add(new BankAccount("DDB123456790", "Anna Kurnikova", 10000000, "RUB"));
            accounts.Add(new BankAccount("DDB123456791", "Jenifer Lopez", 200, "USD"));

            accounts[0].AddToBalance(1000000, DateTime.Now, "donation");

            accounts[1].TakeFromBalance(149284, DateTime.Now, "New car");
            accounts[1].TakeFromBalance(900000000, DateTime.Now, "New makeup");

            foreach (var account in accounts)
            {
                account.Print();
                account.PrintTransactions();
            }
        }
    }
}