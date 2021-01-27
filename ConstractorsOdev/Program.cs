using System;

namespace ConstructorsOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer {Id=1, FirstName="Sara", LastName="Key", City="İA-STET"};
            Customer customer2 = new Customer ( 2, "Mei", "Key", "İA-STET" );
            Console.WriteLine(customer2.FirstName);
        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}   
