using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Pogramming
{
    internal class BankAccount
    {
        private string firstName;
        private string lastName;
        public string password;
        public int balance;
        private Bank bank;
        private bool isLogged;

        public BankAccount(string firstName, string lastName, string password, Bank bank)
        { 
            this.firstName = firstName;
            this.lastName = lastName;   
            this.password = password;
            this.bank = bank;
        }

        public void Deposit(int value)
        {
            if (isLogged == false)
                Console.WriteLine("You have to log in to proceed.");
            else
                balance += value;
        }

        public void WithDrawal(int value)
        {
            if (isLogged == false)
                Console.WriteLine("You have to log in to proceed.");
            else
                balance -= value;
        }

        public void Status()
        {
            if (isLogged == false)
                Console.WriteLine("You have to log in to proceed.");
            else
                Console.WriteLine($"Money in account: {balance}");
        }

        public void Login(string pass)
        {
            if (pass == password)
            {
                isLogged = true;
                Console.WriteLine("Logged in.");
            }
            else
            {
                isLogged = false;
                Console.WriteLine("Wrong password.");
            }
        }
    }
}
