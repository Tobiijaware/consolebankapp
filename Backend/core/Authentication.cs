using System;
using System.Collections.Generic;
using System.Text;
using BankApp1.Backend.Common;
using BankApp1.Backend.Models;

namespace BankApp1.Backend.core
{
    public class Authentication
    {
        public static int Welcome()
        {
            

            Console.Write("\nWELCOME TO DOTNET BANK");
            Console.Write("\nDo You Want To Register? (Type 1)");
            //Console.Write("\nAlready Have An Account, Login (Type 2)");
            Console.Write("\nTo Exit Press Any Key");

            Console.Write("\nSelect Option: ");
            int input = int.Parse(Console.ReadLine()); 
             while (input != 1)
            {
                Console.WriteLine("\nInvalid Option!!!");
                Console.Write("\nSelect Option: ");
                input = int.Parse(Console.ReadLine());
            }
            return input;

        }

        //Registratiom method
        public static Customer Registration(int reg)
        {
            Customer NewCustomer = default;
            
            if (reg == 1)
            {
                List<Customer> AllCustomers = new List<Customer>();
                List<Customer> LoggedInCust = new List<Customer>();
                try
                {
                    Console.Write("\nCREATE YOUR ACCOUNT");


                    Console.Write("\nEnter Your First Name: ");
                    var firstName = Utilities.FirstCharacterToUpper(Utilities.RemoveDigits(Console.ReadLine()));


                    Console.Write("\nEnter Your Middle Name: ");
                    var middleName = Utilities.FirstCharacterToUpper(Utilities.RemoveDigits(Console.ReadLine()));

                    Console.Write("\nEnter Your Last Name: ");
                    var lastName = Utilities.FirstCharacterToUpper(Utilities.RemoveDigits(Console.ReadLine()));

                    Console.Write("\nEnter Your Email: ");
                    var email = Console.ReadLine();

                    while (Utilities.isValidEmail(email) == false)
                    {
                        Console.WriteLine("Invalid Email Address");

                        Console.Write("\nEnter Your Email: ");
                        email = Console.ReadLine();
                    }

                    if (Utilities.isValidEmail(email) == true)
                    {
                        Console.Write("\nEnter Your Password: ");
                        var password = Console.ReadLine();


                        Console.WriteLine($"You Have Successfully Registered {lastName}");

                        NewCustomer = new Customer(firstName, middleName, lastName, email, password);
                        Console.WriteLine($"\n{NewCustomer.FirstName}");
                        AllCustomers.Add(NewCustomer);
                        LoggedInCust.Add(NewCustomer);


                    }
                   

                }
                catch (Exception e)
                {
                    Console.WriteLine("\n\nCaught Error: " + e.Message);
                }

            }
           
                //Console.WriteLine(NewCustomer.Email);
           
            return NewCustomer;
        }


            public static bool Login(Customer NewCustomer)
            {

                bool isLoggedin = false;
                Console.Write($"\nSIGN IN HERE {NewCustomer.FirstName}  {NewCustomer.LastName}");

                Console.Write("\nEnter Your Email: ");
                string _email = Console.ReadLine();
                while (_email != NewCustomer.Email)
                {
                    Console.WriteLine("\nIncorrect Email");
                    Console.Write("\nEnter Your Email: ");
                    _email = Console.ReadLine();
                }


                Console.Write("\nEnter Your Password: ");
                string _password = Console.ReadLine();
                while (_password != NewCustomer.Password)
                {
                    Console.WriteLine("\nIncorrect Password");
                    Console.Write("\nEnter Your Password: ");
                    _password = Console.ReadLine();
                }




            //check if the registration details and the input details match for validation
            if (_email == NewCustomer.Email && _password == NewCustomer.Password)
                {

                    isLoggedin = true;
                    
                }
              
                   
              
                return isLoggedin;
        
            }

       


    }
}
