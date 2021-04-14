using System;
using System.Collections.Generic;
using BankApp1.Backend.core;
using BankApp1.Backend.CreateAcc;
using BankApp1.Backend.Models;



namespace BankApp1
{
    class Program
    {
       
        static void Main(string[] args)
        {
           
            int option = Authentication.Welcome();

            if(option == 1)
            {
                Console.Clear();
                var registration = Authentication.Registration(option);

                if (registration != null)
                {
                    Console.Clear();
                    var login = Authentication.Login(registration);

                    if (login == true)
                    {
                        Console.Clear();
                        var account = Dashboard.ShowDashboard(registration);
                        //AllAccounts.Add(account);



                        if (account != null)
                        {
                            Console.Clear();
                            var response = AccountOperations.UserAccountOperations(account);

                            if (response != null)
                            {
                                Console.WriteLine("Back To Base");
                              //AccountOperations.UserAccountOperations(response);



                            }
                        }
                    }
                }
            }
           

        }
        


    }
}
