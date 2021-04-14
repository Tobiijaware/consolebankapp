using System;
using System.Collections.Generic;
using System.Text;

namespace BankApp1.Backend.Models
{
    public class Customer
    {
       
        public Customer(string firstname, string middlename, string lastname, string email, string password)
        {
            
            this.FirstName = firstname;
            this.MiddleName = middlename;
            this.LastName = lastname;
            this.Email = email;
            this.Password = password;
            
        }
       
       


       // public string Id = Guid.NewGuid().ToString();

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string Password { get; set; }

        public string Email { get; set; }

        //public List<Customer> AllCustomers;

      
            
       

        
       
      
    }
}
