using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();

            ProductManager productManager = new ProductManager();
            productManager.Add();

            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "PETE";
            customer1.LastName = "CROW";
            customer1.City = "California";

            Customer customer2 = new Customer 
            {
                Id = 2, FirstName ="BEAN", LastName = "HYTAN" , City = "California"
                
            };
            Console.WriteLine(customer2);
                
            
            
            
            Console.ReadLine();
        }
    }
}
