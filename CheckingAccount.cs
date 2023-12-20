using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_day04_02
{
   public class CheckingAccount:Account
    {
        public double Fee = 1.5;
        public CheckingAccount(string _name= "unknown_CheckingAccount", double _balance=0) : base(_name, _balance) { }

        public override bool Withdraw(double amount)
        {
            amount += Fee;
            Console.WriteLine(  "hello from base withdraw");
            return  base.Withdraw(amount);
        }
    }
}
