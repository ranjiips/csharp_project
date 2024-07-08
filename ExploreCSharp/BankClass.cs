using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExploreCSharp
{

    public class BankClass
    {
        private string name;
        private string accountNumber;
        private double balance;
        public string Name 
        {
            get { return name; }
            set { name = value; } 
        }
        public string AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }
        public double CurrentBalance
        {
            get { return balance; }
            set { balance = value; }
        }
    }
    interface IAccount { double CalculateInterest(BankClass account); }

    public class SavingsAccount:IAccount
    {
        public double CalculateInterest(BankClass account)
        {
            return account.CurrentBalance * 0.4;
        }
    }

    public class CurrentAccount:IAccount
    {
        public double CalculateInterest(BankClass account)
        {
            return account.CurrentBalance * 5.2;
        }
    }

    public class BusinessAccount:IAccount
    {
        public double CalculateInterest(BankClass acc)
        {
            return acc.CurrentBalance * 5.8;
        }
    }
}
