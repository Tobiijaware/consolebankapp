using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.Models
{
    public class Transactions
    {
        public decimal Amount { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public Transactions(decimal amount, DateTime date, string note)
        {
            this.Amount = amount;
            this.Date = date;
            this.Notes = note;
        }
    }

   public class InterAccountTransactions
    {
        public decimal Amount { get; }
        public int AccountNumber { get; }
        public DateTime Date { get; }
        public string Notes { get; }

        public InterAccountTransactions(decimal amount, DateTime date, string note, int accountNumber)
        {
            this.Amount = amount;
            this.Date = date;
            this.AccountNumber = accountNumber;
            this.Notes = note;
        }
    }
}
