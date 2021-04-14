using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.Models
{
    class CurrentAccount : Account
    {
        public CurrentAccount(string firstname, string lastname, decimal balance, int accountNumber, string accounttype)
           : base(firstname, lastname, balance, accountNumber, accounttype)
        {

        }


        public override decimal Balance
        {
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }
        }

        public override bool Withdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transactions(-amount, date, note);
            AllTransaction.Add(withdrawal);
             return true;

        }

        public decimal Transfer(int amount)
        {
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            decimal amt = amount;
            return amt;
        }


        public bool SendFunds(decimal amount, DateTime date, string note)
        {

            var withdrawal = new Transactions(-amount, date, note);
            AllTransaction.Add(withdrawal);

            Console.WriteLine("Transfer Successful");
            return true;
        }

        public void ReceiveMoney(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, note);
            AllTransaction.Add(deposit);

        }
    }
}
