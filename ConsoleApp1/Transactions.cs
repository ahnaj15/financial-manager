using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Transactions
    {
        public double Amount { get; }
        public DateTime Date { get; }
        public string Note { get; }
        public string Category { get; }
        public Transactions(double amount, DateTime date, string note, string category) 
        {
            Amount = amount;
            Date = date;
            Note = note;
            Category = category;

        }
    }
}
