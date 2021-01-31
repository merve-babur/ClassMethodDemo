using System;
using System.Collections.Generic;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            {
                customer.Id = 0001;
                customer.Name = "Mehmet";
                customer.LastName = "Dar";
                customer.PhoneNumber = "+90 545 987 65 62";
                customer.Email = "mehmetdar@mail.com";
            }
            Customer customer1 = new Customer();
            {
                customer1.Id = 0002;
                customer1.Name = "Mehtap";
                customer1.LastName = "Dem";
                customer1.PhoneNumber = "+90 543 574 65 42";
                customer1.Email = "mehtapdar@mail.com";

            }
            Customer customer2 = new Customer();
            {
                customer2.Id = 0003;
                customer2.Name = "Maria";
                customer2.LastName = "Kim";
                customer2.PhoneNumber = "+90 541 775 75 75";
                customer2.Email = "mariakim@mail.com";
            }
            List<Customer> customers = new List<Customer> { customer, customer1, customer2 };
            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("------ Welcome to system ------");
            Console.WriteLine("------ Please press to 'Enter' ------");
            Console.WriteLine("------ Please keep pressing 'Enter' after each action takes place. ------");
            Console.ReadKey();
            Console.WriteLine("------ Customer Creation ------");
            customerManager.Add(customer);
            Console.WriteLine("------ Customer Remove ------");
            customerManager.Remove(customer1);
            Console.WriteLine("------ Customer List ------");
            customerManager.CustomerList(customers); 
        }
        
    }
}
