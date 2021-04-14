using BankApp1.Backend.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.core
{
    public class Dashboard
    {
        public static List<Account> Accounts = new List<Account>();



        public static Account ShowDashboard(Customer NewCustomer)
        {
           


            Account newaccount = default;
           


            Console.Write($"\nWELCOME TO YOUR DASHBOARD {NewCustomer.FirstName} {NewCustomer.LastName}");

            //Account Creation
            Console.Write("\nCreate An Account (Yes) ");
            string response = Console.ReadLine();
            Console.Clear();


            Console.Write("\nSavings (Type 1) Or Current (Type 2)? ");
            int accountres = int.Parse(Console.ReadLine());
            while (accountres != 1 && accountres != 2)
            {
                Console.Write("\nSavings (Type 1) Or Current (Type 2)? ");
                 accountres = int.Parse(Console.ReadLine());
            }
            Console.Clear();

           

           
                if (accountres == 1)
                {
                    //creating the savings account
                    newaccount = CreateAcc.CreateAcc.CreateSavingsAccount(NewCustomer);
                    Accounts.Add(newaccount);

                    foreach (Account item in Accounts)
                    {
                        Console.WriteLine($"Your Account Number is {item.AccountNumber} And Your Account Type is {item.AccountType}");

                    }

                }
                else if (accountres == 2)
                {
                    //creating the savings account
                    newaccount = CreateAcc.CreateAcc.CreateCurrentAccount(NewCustomer);
                    Accounts.Add(newaccount);

                    foreach (Account item in Accounts)
                    {
                        Console.WriteLine($"Your Account Number is {item.AccountNumber} And Your Account Type is {item.AccountType}");


                    }

                }
               
           
           
           
          



            return newaccount;

            //End of Account Creation and return Account
        }
    }

   

}
