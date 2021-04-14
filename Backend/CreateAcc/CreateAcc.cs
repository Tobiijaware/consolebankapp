using BankApp1.Backend.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.CreateAcc
{
    public class CreateAcc 
    {
        
        internal static Account CreateSavingsAccount(Customer NewCustomer) 
        {
            int accountNumber = GenerateRandomInt();
            string accounttype = "Savings";
            decimal defaultbalance = 1000;
            Account userAccount = new Account(NewCustomer.FirstName,NewCustomer.LastName, defaultbalance, accountNumber,accounttype);
            return userAccount;
        }

        internal static Account CreateCurrentAccount(Customer NewCustomer)
        {

            int accountNumber = GenerateRandomInt();
            string accounttype = "Current";
            decimal defaultbalance = 0;
            Account userAccount = new Account(NewCustomer.FirstName, NewCustomer.LastName, defaultbalance, accountNumber, accounttype);
            return userAccount;


        }


        private static int GenerateRandomInt()
        {
            Random rnd = new Random();
            int RandomNumber = rnd.Next(1000000000, 2000000000);
            return RandomNumber;
        }


    }
}
