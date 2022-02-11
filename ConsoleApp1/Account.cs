using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Account
    {
        public string OwnerName { get; set; }
        public double Balance {
            get 
            {
                double balance = 0;
                foreach (var item in allTransactions)
                    balance += item.Amount;
                return balance;
            } 
        }
        public double BusinessBalance
        {
            get
            {
                double businessBalance = 0;
                foreach (var item in allTransactions)
                {
                    if(item.Category == "Business")
                        businessBalance += item.Amount;
                }
                return businessBalance;
            }
        }
        public double NeedsBalance
        {
            get
            {
                double needsBalance = 0;
                foreach (var item in allTransactions)
                {
                    if (item.Category == "Needs")
                        needsBalance += item.Amount;
                }
                return needsBalance;
            }
        }
        public double MustBalance
        {
            get
            {
                double mustBalance = 0;
                foreach (var item in allTransactions)
                {
                    if (item.Category == "Must")
                        mustBalance += item.Amount;
                }
                return mustBalance;
            }
        }
        public double FunBalance
        {
            get
            {
                double funBalance = 0;
                foreach (var item in allTransactions)
                {
                    if (item.Category == "Business")
                        funBalance += item.Amount;
                }
                return funBalance;
            }
        }
        public double SavingsBalance
        {
            get
            {
                double savingsBalance = 0;
                foreach (var item in allTransactions)
                {
                    if (item.Category == "Business")
                        savingsBalance += item.Amount;
                }
                return savingsBalance;
            }
        }
        private List<Transactions> allTransactions = new List<Transactions>();
        public Account(string Name, double InitialBudget) 
        {
            OwnerName = Name;
            
            MoneyIncome(InitialBudget, DateTime.Now, "Initial Budget");
            
        }
        public void MoneyIncome (double amount, DateTime date, string note)
        {
            if(amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount must be positive");
            }
            var income = new Transactions(amount, date, note, "Income");
            allTransactions.Add(income);
        }
        public void ExpensesBusiness(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount must be positive");
            }
            if(Balance - amount < 0)
            {
                throw new InvalidOperationException("You don't have enough money !");
            }
            var ExpBusiness = new Transactions(-amount, date, note, "Business");
            allTransactions.Add(ExpBusiness);
        }
        public void ExpensesNeeds(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("You don't have enough money !");
            }
            var ExpNeeds = new Transactions(-amount, date, note, "Needs");
            allTransactions.Add(ExpNeeds);
        }
        public void ExpensesMust(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("You don't have enough money !");
            }
            var ExpMust = new Transactions(-amount, date, note, "Must");
            allTransactions.Add(ExpMust);
        }
        public void ExpensesFun(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("You don't have enough money !");
            }
            var ExpFun = new Transactions(-amount, date, note, "Fun");
            allTransactions.Add(ExpFun);
        }
        public void ExpensesSavings(double amount, DateTime date, string note)
        {
            if (amount < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "The amount must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("You don't have enough money !");
            }
            var ExpSavings = new Transactions(-amount, date, note, "Savings");
            allTransactions.Add(ExpSavings);
        }
    }
}
