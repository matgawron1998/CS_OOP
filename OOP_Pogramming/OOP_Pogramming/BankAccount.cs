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
        private string password;

        private int balance;

        public BankAccount(string firstName, string lastName, string password)
        { 
            this.firstName = firstName;
            this.lastName = lastName;   
            this.password = password;
        }

        public void Deposit(int value)
        {
            balance += value;
        }

        public void WithDrawal(int value)
        {
            balance -= value;
        }

        public void Status()
        {
            Console.WriteLine($"Money in account: {balance}");
        }
    }
}
