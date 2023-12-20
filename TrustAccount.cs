using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day04_02
{
    public class TrustAccount : SavingsAccount
    {
        public int NumberOfWithdraw_Year=3;
        public TrustAccount(string _name = "UnKnown_Trust_Account", double _balance = 0, double _interestRate = 0) : base(_name, _balance, _interestRate) { }

        public override bool Deposit(double amount)
        {
            if (amount < 0)
                return false;
            else if (amount >= 5000)
            {
                Balance += amount + 50;
                Console.WriteLine("you received a $50.00 bonus deposited to your account.");
                return true;
            }
            else
            {
                Balance += amount;
                return true;
            }

        }

        public override bool Withdraw(double amount)

        {
            Console.WriteLine("hellow from Trust class");
            double allowedWithdrawAmount = this.Balance * .2;
            if (amount < allowedWithdrawAmount && amount > 0 && NumberOfWithdraw_Year > 0)
            {
                Console.WriteLine(NumberOfWithdraw_Year);
                Balance -= amount;
                NumberOfWithdraw_Year--;
                return true;
            }
            else   return false;
            
        }
        public override string ToString()
        {
            return $"[Account: Name: {Name} , Balance : {Balance:C} , interest Rate : {InterestRate:P} ,allowoed Number of withdraw this year : {NumberOfWithdraw_Year} times]";
        }
    }

}
