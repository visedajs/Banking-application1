﻿using System;
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

            foreach (var account in accounts)
            {
                account.Print();
            }
        }
    }

    public class BankAccount
    {
        public string Number { get; }
        public string Owner { get; }
        public decimal Balance { get; }
        public string Currency { get; }
        public DateTime DateCreated { get; }

        public BankAccount(string number, string owner, decimal balance, string currency)
        {
            this.Number = number;
            this.Owner = owner;
            this.Balance = balance;
            this.Currency = currency;
            this.DateCreated = DateTime.Now;
        }

        public void Print()
        {
            Console.WriteLine($"Account {this.Number} belongs to {this.Owner} and has a balance of {this.Balance} {this.Currency}");
        }


    }
}