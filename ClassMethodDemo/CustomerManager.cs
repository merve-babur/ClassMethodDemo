using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine(customer.Name +" "+  customer.LastName+ " added to successfully customer list.\n");
            Console.ReadKey();
        }
        public void Remove(Customer customer)
        {
            Console.WriteLine(customer.Name + " " + customer.LastName+ " remove at to successfully customer list.\n");
            Console.ReadKey();
        }
        public void CustomerList(List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("----"+customer.Id+"----");
                Console.WriteLine("Customer Info= "+ customer.Name+ " "+ customer.LastName);
                Console.WriteLine("Customer Phone Number= " +customer.PhoneNumber);
                Console.WriteLine("Customer Email Address= " +customer.Email);
            }
            Console.ReadKey();
        }

    }
}
