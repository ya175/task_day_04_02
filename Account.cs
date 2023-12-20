using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day04_02
{
    public class Account
    {
        private string name;
        private double balance;

        public string Name { get => name; set => name = value; }
        public double Balance { get => balance; set => balance = value; }

        public Account(string name = "Unnamed Account", double balance = 0.0)
        {
            this.name = name;
            this.balance = balance;
        }

        public virtual bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else
            {
                balance += amount;
                return true;
            }
        }

        public virtual bool Withdraw(double amount)
        {
            if (balance - amount >= 0)
            {
                balance -= amount;
                return true;
            }
            else
            {
                return false;
            }
        }

        public double GetBalance()
        {
            return balance;
        }

        public override string ToString()
        {
            return $"[Account: {name}: {balance:C}]";
        }
        public static Account operator +(Account acc_1, Account acc_2)
        {
            Account newAccount=new Account (balance : acc_1.balance + acc_2.balance);
            return newAccount;

        }
    }
}
