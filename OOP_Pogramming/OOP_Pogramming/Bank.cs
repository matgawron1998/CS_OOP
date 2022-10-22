using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class Bank
    {
        public string Name;

        private List<BankAccount> account = new List<BankAccount>();
        private bool isLogged;

        public Bank(string name)
        {
            Name = name;
        }

        public BankAccount AddClient(string firstName, string lastName, string password, Bank bank)
        {
            BankAccount clientAccount = new BankAccount(firstName, lastName, password, bank);
            account.Add(clientAccount);
            return clientAccount;
        }

        public BankAccount GetAccount(int index)
        {
            return account[index];
        }

        public void RemoveClient(BankAccount clientAccount)
        { 
            account.Remove(clientAccount);
        }

        public void LoginClient(string pass, BankAccount clientAccount)
        {
            if (pass == clientAccount.password)
            {
                isLogged = true;
                Console.WriteLine("Logged in.");
            }
            else 
            {
                isLogged = false;
                Console.WriteLine("Worng password.");
            }
        }

        public void Deposit(int value, BankAccount clientAccount)
        {
            if (!isLogged)
            {
                Console.WriteLine("You have to log in to proceed.");
                return;
            }
            clientAccount.balance += value;
        }

        public void WithDrawal(int value, BankAccount clientAccount)
        {
            if (!isLogged)
            {
                Console.WriteLine("You have to log in to proceed.");
                return;
            }
            clientAccount.balance -= value;
        }

        public void State(BankAccount clientAccount)
        {
            if (!isLogged)
            {
                Console.WriteLine("You have to log in to proceed.");
                return;
            }
            Console.WriteLine($"Money in account: {clientAccount.balance}");
        }
    }
}
