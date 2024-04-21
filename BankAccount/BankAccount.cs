using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public class BankAccount
    {
        private int id;
        private double balance;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void Deposit(double amount)
        {
            this.balance += amount;
        }
        public void WithDraw(double amount)
        {
            this.balance -= amount;
        }
        public void Print()
        {
            Console.WriteLine($"Account {this.id}, balance {this.balance}");
        }
    }
}