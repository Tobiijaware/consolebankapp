using System;
using BankApp1.Backend.Models;
using BankApp1.Backend.core;
using BankApp1.Backend.Common;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.CreateAcc
{
    public class AccountOperations
    {
        public static Account UserAccountOperations(Account userAccount)
        {


            //display and select dashboard options
            Console.Write($"\nYour Account Number is {userAccount.AccountNumber} & Type is {userAccount.AccountType}");

            Console.Write("\nTRANSACTIONS)");
            Console.Write("\nTo Deposit  (Press 1)");
            Console.Write("\nTo Withdraw  (Press 2)");
            Console.Write("\nTo Get Balance  (Press 3)");
            Console.Write("\nTo Transfer  (Press 4)");
            Console.Write("\nTo Print Account Statement (Press 5)");
            Console.Write("\nTo Logout (Press 6)");

            Console.Write("\nEnter Option: ");
            int input = int.Parse(Console.ReadLine());

            while (input <= 0 || input > 6)
            {
                Console.WriteLine("\nInvalid Selection"); 
                Console.Write("\nEnter Option: ");
                input = int.Parse(Console.ReadLine());
            }



            if (input == 1)
            {
                Console.Clear();
                Console.Write("\nAccount Type: Press 1 for Savings / 2 for Current: ");
                var res = int.Parse(Console.ReadLine());
                if (res == 1 && userAccount.AccountType == "Savings")
                {
                    //Deposit

                    Console.Clear();
                    Console.Write("\nEnter Amount: ");
                    var amount = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter Transaction Note: ");
                    var note = Console.ReadLine();

                    var date = DateTime.Now;

                    Account account = new SavingsAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var success = account.Deposit(amount, date, note);
                    Console.WriteLine($"You Have Successfully Deposited {amount} Into Your Account, Your Balance is {account.Balance}");

                    while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                   


                }
                else if (res == 2 && userAccount.AccountType == "Current")
                {
                    Console.Clear();
                    Console.Write("\nEnter Amount: ");
                    var amount = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter Transaction Note: ");
                    var note = Console.ReadLine();

                    var date = DateTime.Now;

                    Account account = new CurrentAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var success = account.Deposit(amount, date, note);
                    Console.WriteLine($"You Have Successfully Deposited {amount} Into Your Account, Your Balance is {account.Balance}");

                     while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                   
                }
                else
                {
                    throw new Exception("Error, Invalid Transaction");
                }



            }

            else if (input == 2)
            {
                Console.Clear();
                Console.Write("\nAccount Type: Press 1 for Savings / 2 for Current: ");
                var res = int.Parse(Console.ReadLine());
                if (res == 1 && userAccount.AccountType == "Savings")
                {
                    Console.Clear();
                    Console.Write("\nEnter Amount: ");
                    var amount = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter Transaction Note: ");
                    var note = Console.ReadLine();

                    var date = DateTime.Now;

                    Account account = new SavingsAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var success = account.Withdrawal(amount, date, note);
                    Console.WriteLine($"You Have Successfully Withdrawn {amount} From Your Account, Your Balance is {account.Balance}");

                     while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                   

                }
                else if (res == 2 && userAccount.AccountType == "Current")
                {

                    //Withdrawal
                    Console.Clear();
                    Console.Write("\nEnter Amount: ");
                    var amount = int.Parse(Console.ReadLine());

                    Console.Write("\nEnter Transaction Note: ");
                    var note = Console.ReadLine();

                    var date = DateTime.Now;

                    Account account = new CurrentAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var success = account.Withdrawal(amount, date, note);
                    Console.WriteLine($"You Have Successfully Withdrawn {amount} From Your Account, Your Balance is {account.Balance}");

                    while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                   
                }
                else
                {
                    throw new Exception("Error, Invalid Transaction");
                }

            }
            else if (input == 3)
            {
                //get Balance
                Console.Clear();
                Console.Write("\nSelect Account (Press 1 for Saving / Press 2 for Current): ");
                var resp = int.Parse(Console.ReadLine());

                if (resp != 1 && resp != 2)
                {
                    throw new Exception("Invalid Selection");
                }
                else if (resp == 1)
                {
                    Console.Clear();
                    Account account = new SavingsAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var balance = account.Balance;
                    Console.WriteLine($"Your Savings Account Balance is {balance}");

                    while(balance >= 0){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                   







                }
                else if (resp == 2)
                {
                    Console.Clear();
                    Account account = new CurrentAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var balance = account.Balance;
                    Console.WriteLine($"Your Current Account Balance is {balance}");


                    while(balance >= 0){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                }
                
            }
            else if (input == 4)
            {
                //Transfer 
                Console.Clear();
                Console.Write("\nSelect Account (Press 1 for Saving / Press 2 for Current): ");
                var resp = int.Parse(Console.ReadLine());

                if (resp != 1 && resp != 2)
                {
                    throw new Exception("Invalid Selection");
                }
                else if (resp == 1)
                {
                    //Transfer From Savings Account;
                    Console.Clear();
                    var allaccounts = Dashboard.Accounts;
                    
                    foreach (Account item in allaccounts)
                    {
                        Console.WriteLine($"Account Name Is {item.FirstName + item.LastName} And Number Is {item.AccountNumber}");
                        Console.WriteLine(item.AccountType);
                        Console.WriteLine(item.FirstName);
                       
                    }

                    Console.Write("\nEnter Amount: ");
                    var amount = int.Parse(Console.ReadLine());

                    /*Console.Write("\nEnter Recipient: ");
                    var accno = int.Parse(Console.ReadLine());*/


                    Console.Write("\nEnter Note: ");
                    var note = Console.ReadLine();


                    SavingsAccount account = new SavingsAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var value = account.Transfer(amount);

                    var success = account.SendFunds(value, DateTime.Now, note);

                    while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }






                }
                else if(resp == 2)
                {
                    //Transfer From current Account;
                    Console.Clear();
                    var allaccounts = Dashboard.Accounts;

                    foreach (Account item in allaccounts)
                    {
                        Console.WriteLine($"Account Name Is {item.FirstName + item.LastName} And Number Is {item.AccountNumber}");
                        Console.WriteLine(item.AccountType);
                        Console.WriteLine(item.FirstName);

                    }

                    Console.Write("\nEnter Amount: ");
                    var amount = int.Parse(Console.ReadLine());

                   /* Console.Write("\nEnter Recipient: ");
                    var accno = int.Parse(Console.ReadLine());*/


                    Console.Write("\nEnter Note: ");
                    var note = Console.ReadLine();


                    CurrentAccount account = new CurrentAccount(userAccount.FirstName, userAccount.LastName, userAccount.Balance, userAccount.AccountNumber, userAccount.AccountType);
                    var value = account.Transfer(amount);
                    var success = account.SendFunds(value, DateTime.Now, note);


                     while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }
                }
                //Console.WriteLine(userAccount.Balance);
               
            }else if (input == 5)
            {
                //Print Account Statement
               var success = DisplayReport(userAccount);

                 while(success){
                        Console.Write("\nTo Go Back (Press 1): ");
                        var back = int.Parse(Console.ReadLine());

                        while(back != 1){

                            Console.Write("\nTo Go Back (Press 1): ");
                            back = int.Parse(Console.ReadLine());
                        }

                        if(back == 1){
                            UserAccountOperations(userAccount);
                        }
                    }



            }else if(input == 6){
                
            }
                 
            












            return userAccount;

        }




        public static bool DisplayReport(Account customer)
        {

            if (customer == null)
                Console.WriteLine("Account is empty!");

            int widthOfTable = 85;
            Console.Clear();

            Utilities.PrintLine(widthOfTable);
            Utilities.PrintRow(widthOfTable, $"STATEMENT OF ACCOUNT FOR {customer.FirstName} {customer.LastName}");
            Utilities.PrintLine(widthOfTable);

            Utilities.PrintRow(widthOfTable, "AMOUNT", "DATE", "NOTE");
            Utilities.PrintLine(widthOfTable);


            for (int i = 0; i < Account.AllTransaction.Count; i++)
            {
                Utilities.PrintRow(widthOfTable, Account.AllTransaction[0].Amount.ToString(), Account.AllTransaction[0].Date.ToString(), Account.AllTransaction[0].Notes.ToString());
            }

            Utilities.PrintLine(widthOfTable);



            Console.ReadLine();

            return true;
        }

    }
}
