using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace task_day04_02
{
    public class SavingsAccount:Account
    {
        public double InterestRate;


        public SavingsAccount(string _name="unknown_saving",double _balance=0, double _InterestRate=0):base(_name,_balance) {
            this.InterestRate = _InterestRate;
        }
        public override string ToString()
        {
            return $"[Account: Name: {Name} , Balance : {Balance:C} , Interest Rate : {InterestRate:P}]";
        }

    }
}
