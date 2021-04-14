
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.Models
{

   
    public  class Account
    {


        public static List<Transactions> AllTransaction = new List<Transactions>();

        public Account(string firstname, string lastname, decimal balance, int accountNumber, string accounttype)
        {
            this.FirstName = firstname;
            this.LastName = lastname;
            this.AccountNumber = accountNumber;
            this.AccountType = accounttype;
        }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

       

        //internal List<InterAccountTransactions> InterAccountTransactions = new List<InterAccountTransactions>();

        internal int AccountNumber { get; set; }

        internal string AccountType { get; set; }

      

       

        public virtual decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in AllTransaction)
                {
                    balance += item.Amount;
                }
                return balance;
            }
            set { 
            }
        }

        public bool Deposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transactions(amount, date, note);
            AllTransaction.Add(deposit);
            return true;
        }

        public virtual bool Withdrawal(decimal amount, DateTime date, string note)
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



       



    }

  
}
